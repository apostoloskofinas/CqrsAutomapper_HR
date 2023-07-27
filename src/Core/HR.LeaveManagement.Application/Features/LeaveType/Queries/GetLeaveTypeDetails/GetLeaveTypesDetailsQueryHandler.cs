﻿using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistance;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
public class GetLeaveTypeDetailsQueryHandler : IRequestHandler<GetLeaveTypeDetailsQuery, 
    LeaveTypeDetailsDto>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public GetLeaveTypeDetailsQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        this._mapper = mapper;
        this._leaveTypeRepository = leaveTypeRepository;
    }

    public async Task<LeaveTypeDetailsDto> Handle(GetLeaveTypeDetailsQuery request,  CancellationToken cancellationToken)
    {
        var leaveType = await _leaveTypeRepository.GetByIdAsync(request.Id);
        var data = _mapper.Map<LeaveTypeDetailsDto> (leaveType);
        return data;
    }
}