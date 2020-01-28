using Modelo.Domain.Core.Bus;
using Modelo.Domain.Core.Commands;
using FluentValidation.Results;
using System.Threading.Tasks;
using MediatR;

namespace Modelo.Domain.Core.Notifications
{
    public abstract class Notifiable
    {
        private readonly IMediatorHandler _bus;
        private readonly NotificationHandler _notifications;

        protected Notifiable(IMediatorHandler bus, INotificationHandler<Notification> notifications)
        {
            _bus = bus;
            _notifications = (NotificationHandler)notifications;
        }

        protected virtual async Task ValidateAndNotifyValidationErrors(Command message)
        {
            await message.IsValid();
            await NotifyValidationErrors(message);
        }

        protected virtual Task NotifyValidationErrors(Command message)
        {
            return NotifyValidationErrors(message.ValidationResult);
        }

        protected virtual async Task NotifyValidationErrors(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                await Notify(error.PropertyName, error.ErrorMessage);
            }
        }

        protected virtual Task Notify(string key, string value)
        {
            return Notify(new Notification(key, value));
        }

        protected virtual Task Notify(Notification notification)
        {
            return _bus.RaiseEvent(notification);
        }

        protected virtual bool IsValid()
        {
            return !_notifications.HasNotifications();
        }
    }
}
