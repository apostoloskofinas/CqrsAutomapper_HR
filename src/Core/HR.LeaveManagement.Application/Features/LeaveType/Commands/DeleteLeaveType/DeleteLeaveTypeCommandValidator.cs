using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistance;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveType;

//TODO
//THIS VALIDATIONS ARE JUST COPIED
public class DeleteLeaveTypeCommandValidator : AbstractValidator<DeleteLeaveTypeCommand>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public DeleteLeaveTypeCommandValidator(ILeaveTypeRepository leaveTypeRepository)
    {
        RuleFor(p => p.Id)
             .LessThan(70).WithMessage("{PropertyName} cannot exceed 100")
             .GreaterThan(1).WithMessage("{PropertyName} cannot be less than 1");

        this._leaveTypeRepository = leaveTypeRepository;
    }
}