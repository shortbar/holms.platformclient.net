// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/open_lodging_reservation_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Booking.RPC {
  public static class OpenLodgingReservationSvc
  {
    static readonly string __ServiceName = "holms.types.booking.rpc.OpenLodgingReservationSvc";

    static readonly Marshaller<global::HOLMS.Types.Booking.Indicators.ReservationIndicator> __Marshaller_ReservationIndicator = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Indicators.ReservationIndicator.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.GetReservationHistoryResponse> __Marshaller_GetReservationHistoryResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.GetReservationHistoryResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsRequest> __Marshaller_UpdateRoomAssignmentsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsResponse> __Marshaller_UpdateRoomAssignmentsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.Reservations.ReservationRoomAssignmentSchedule> __Marshaller_ReservationRoomAssignmentSchedule = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.ReservationRoomAssignmentSchedule.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.GetReservationContactsResponse> __Marshaller_GetReservationContactsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.GetReservationContactsResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.RemoveReservationContactRequest> __Marshaller_RemoveReservationContactRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.RemoveReservationContactRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.AddReservationContactRequest> __Marshaller_AddReservationContactRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.AddReservationContactRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.HousekeepingTimePreferenceRequest> __Marshaller_HousekeepingTimePreferenceRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.HousekeepingTimePreferenceRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.Reservations.RecommendedCheckinAuthorizationAmounts> __Marshaller_RecommendedCheckinAuthorizationAmounts = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.RecommendedCheckinAuthorizationAmounts.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.ReservationAssociatedParties> __Marshaller_ReservationAssociatedParties = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.ReservationAssociatedParties.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.History.ReservationCreationSummary> __Marshaller_ReservationCreationSummary = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.History.ReservationCreationSummary.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.History.ReservationAmendmentSummary> __Marshaller_ReservationAmendmentSummary = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.History.ReservationAmendmentSummary.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.VehiclePlateInformationUpdateRequest> __Marshaller_VehiclePlateInformationUpdateRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.VehiclePlateInformationUpdateRequest.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.RPC.GetReservationHistoryResponse> __Method_GetReservationHistory = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.RPC.GetReservationHistoryResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetReservationHistory",
        __Marshaller_ReservationIndicator,
        __Marshaller_GetReservationHistoryResponse);

    static readonly Method<global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsRequest, global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsResponse> __Method_UpdateRoomAssignments = new Method<global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsRequest, global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsResponse>(
        MethodType.Unary,
        __ServiceName,
        "UpdateRoomAssignments",
        __Marshaller_UpdateRoomAssignmentsRequest,
        __Marshaller_UpdateRoomAssignmentsResponse);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.Reservations.ReservationRoomAssignmentSchedule> __Method_GetRoomAssignments = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.Reservations.ReservationRoomAssignmentSchedule>(
        MethodType.Unary,
        __ServiceName,
        "GetRoomAssignments",
        __Marshaller_ReservationIndicator,
        __Marshaller_ReservationRoomAssignmentSchedule);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.RPC.GetReservationContactsResponse> __Method_GetReservationContacts = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.RPC.GetReservationContactsResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetReservationContacts",
        __Marshaller_ReservationIndicator,
        __Marshaller_GetReservationContactsResponse);

    static readonly Method<global::HOLMS.Types.Booking.RPC.RemoveReservationContactRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveReservationContact = new Method<global::HOLMS.Types.Booking.RPC.RemoveReservationContactRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "RemoveReservationContact",
        __Marshaller_RemoveReservationContactRequest,
        __Marshaller_Empty);

    static readonly Method<global::HOLMS.Types.Booking.RPC.AddReservationContactRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddContactPerson = new Method<global::HOLMS.Types.Booking.RPC.AddReservationContactRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "AddContactPerson",
        __Marshaller_AddReservationContactRequest,
        __Marshaller_Empty);

    static readonly Method<global::HOLMS.Types.Booking.RPC.HousekeepingTimePreferenceRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetHousekeepingTimePreference = new Method<global::HOLMS.Types.Booking.RPC.HousekeepingTimePreferenceRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "SetHousekeepingTimePreference",
        __Marshaller_HousekeepingTimePreferenceRequest,
        __Marshaller_Empty);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.Reservations.RecommendedCheckinAuthorizationAmounts> __Method_GetRecommendedCheckinAuthorizationAmounts = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.Reservations.RecommendedCheckinAuthorizationAmounts>(
        MethodType.Unary,
        __ServiceName,
        "GetRecommendedCheckinAuthorizationAmounts",
        __Marshaller_ReservationIndicator,
        __Marshaller_RecommendedCheckinAuthorizationAmounts);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.ReservationAssociatedParties> __Method_GetReservationAssociatedParties = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.ReservationAssociatedParties>(
        MethodType.Unary,
        __ServiceName,
        "GetReservationAssociatedParties",
        __Marshaller_ReservationIndicator,
        __Marshaller_ReservationAssociatedParties);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.History.ReservationCreationSummary> __Method_GetReservationCreationSummary = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.History.ReservationCreationSummary>(
        MethodType.Unary,
        __ServiceName,
        "GetReservationCreationSummary",
        __Marshaller_ReservationIndicator,
        __Marshaller_ReservationCreationSummary);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.History.ReservationAmendmentSummary> __Method_GetReservationAmendmentSummary = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.History.ReservationAmendmentSummary>(
        MethodType.Unary,
        __ServiceName,
        "GetReservationAmendmentSummary",
        __Marshaller_ReservationIndicator,
        __Marshaller_ReservationAmendmentSummary);

    static readonly Method<global::HOLMS.Types.Booking.RPC.VehiclePlateInformationUpdateRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateVehiclePlateInformation = new Method<global::HOLMS.Types.Booking.RPC.VehiclePlateInformationUpdateRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "UpdateVehiclePlateInformation",
        __Marshaller_VehiclePlateInformationUpdateRequest,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Booking.RPC.OpenLodgingReservationSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of OpenLodgingReservationSvc</summary>
    public abstract class OpenLodgingReservationSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.GetReservationHistoryResponse> GetReservationHistory(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsResponse> UpdateRoomAssignments(global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.Reservations.ReservationRoomAssignmentSchedule> GetRoomAssignments(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.GetReservationContactsResponse> GetReservationContacts(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> RemoveReservationContact(global::HOLMS.Types.Booking.RPC.RemoveReservationContactRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AddContactPerson(global::HOLMS.Types.Booking.RPC.AddReservationContactRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> SetHousekeepingTimePreference(global::HOLMS.Types.Booking.RPC.HousekeepingTimePreferenceRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Obsolete, use endpoint on check-in service instead
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.Reservations.RecommendedCheckinAuthorizationAmounts> GetRecommendedCheckinAuthorizationAmounts(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.ReservationAssociatedParties> GetReservationAssociatedParties(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.History.ReservationCreationSummary> GetReservationCreationSummary(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.History.ReservationAmendmentSummary> GetReservationAmendmentSummary(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateVehiclePlateInformation(global::HOLMS.Types.Booking.RPC.VehiclePlateInformationUpdateRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for OpenLodgingReservationSvc</summary>
    public class OpenLodgingReservationSvcClient : ClientBase<OpenLodgingReservationSvcClient>
    {
      /// <summary>Creates a new client for OpenLodgingReservationSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OpenLodgingReservationSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OpenLodgingReservationSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OpenLodgingReservationSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OpenLodgingReservationSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OpenLodgingReservationSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Booking.RPC.GetReservationHistoryResponse GetReservationHistory(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationHistory(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.GetReservationHistoryResponse GetReservationHistory(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationHistory, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GetReservationHistoryResponse> GetReservationHistoryAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationHistoryAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GetReservationHistoryResponse> GetReservationHistoryAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationHistory, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsResponse UpdateRoomAssignments(global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateRoomAssignments(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsResponse UpdateRoomAssignments(global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateRoomAssignments, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsResponse> UpdateRoomAssignmentsAsync(global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateRoomAssignmentsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsResponse> UpdateRoomAssignmentsAsync(global::HOLMS.Types.Booking.RPC.UpdateRoomAssignmentsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateRoomAssignments, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.Reservations.ReservationRoomAssignmentSchedule GetRoomAssignments(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetRoomAssignments(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.Reservations.ReservationRoomAssignmentSchedule GetRoomAssignments(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRoomAssignments, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.Reservations.ReservationRoomAssignmentSchedule> GetRoomAssignmentsAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetRoomAssignmentsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.Reservations.ReservationRoomAssignmentSchedule> GetRoomAssignmentsAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRoomAssignments, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.GetReservationContactsResponse GetReservationContacts(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationContacts(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.GetReservationContactsResponse GetReservationContacts(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationContacts, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GetReservationContactsResponse> GetReservationContactsAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationContactsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GetReservationContactsResponse> GetReservationContactsAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationContacts, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveReservationContact(global::HOLMS.Types.Booking.RPC.RemoveReservationContactRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveReservationContact(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveReservationContact(global::HOLMS.Types.Booking.RPC.RemoveReservationContactRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoveReservationContact, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RemoveReservationContactAsync(global::HOLMS.Types.Booking.RPC.RemoveReservationContactRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveReservationContactAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RemoveReservationContactAsync(global::HOLMS.Types.Booking.RPC.RemoveReservationContactRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoveReservationContact, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddContactPerson(global::HOLMS.Types.Booking.RPC.AddReservationContactRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddContactPerson(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddContactPerson(global::HOLMS.Types.Booking.RPC.AddReservationContactRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddContactPerson, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddContactPersonAsync(global::HOLMS.Types.Booking.RPC.AddReservationContactRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddContactPersonAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddContactPersonAsync(global::HOLMS.Types.Booking.RPC.AddReservationContactRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddContactPerson, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetHousekeepingTimePreference(global::HOLMS.Types.Booking.RPC.HousekeepingTimePreferenceRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetHousekeepingTimePreference(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetHousekeepingTimePreference(global::HOLMS.Types.Booking.RPC.HousekeepingTimePreferenceRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetHousekeepingTimePreference, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SetHousekeepingTimePreferenceAsync(global::HOLMS.Types.Booking.RPC.HousekeepingTimePreferenceRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetHousekeepingTimePreferenceAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SetHousekeepingTimePreferenceAsync(global::HOLMS.Types.Booking.RPC.HousekeepingTimePreferenceRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetHousekeepingTimePreference, null, options, request);
      }
      /// <summary>
      ///  Obsolete, use endpoint on check-in service instead
      /// </summary>
      public virtual global::HOLMS.Types.Booking.Reservations.RecommendedCheckinAuthorizationAmounts GetRecommendedCheckinAuthorizationAmounts(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetRecommendedCheckinAuthorizationAmounts(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Obsolete, use endpoint on check-in service instead
      /// </summary>
      public virtual global::HOLMS.Types.Booking.Reservations.RecommendedCheckinAuthorizationAmounts GetRecommendedCheckinAuthorizationAmounts(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRecommendedCheckinAuthorizationAmounts, null, options, request);
      }
      /// <summary>
      ///  Obsolete, use endpoint on check-in service instead
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.Reservations.RecommendedCheckinAuthorizationAmounts> GetRecommendedCheckinAuthorizationAmountsAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetRecommendedCheckinAuthorizationAmountsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Obsolete, use endpoint on check-in service instead
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.Reservations.RecommendedCheckinAuthorizationAmounts> GetRecommendedCheckinAuthorizationAmountsAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRecommendedCheckinAuthorizationAmounts, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.ReservationAssociatedParties GetReservationAssociatedParties(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationAssociatedParties(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.ReservationAssociatedParties GetReservationAssociatedParties(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationAssociatedParties, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.ReservationAssociatedParties> GetReservationAssociatedPartiesAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationAssociatedPartiesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.ReservationAssociatedParties> GetReservationAssociatedPartiesAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationAssociatedParties, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.History.ReservationCreationSummary GetReservationCreationSummary(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationCreationSummary(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.History.ReservationCreationSummary GetReservationCreationSummary(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationCreationSummary, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.History.ReservationCreationSummary> GetReservationCreationSummaryAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationCreationSummaryAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.History.ReservationCreationSummary> GetReservationCreationSummaryAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationCreationSummary, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.History.ReservationAmendmentSummary GetReservationAmendmentSummary(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationAmendmentSummary(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.History.ReservationAmendmentSummary GetReservationAmendmentSummary(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationAmendmentSummary, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.History.ReservationAmendmentSummary> GetReservationAmendmentSummaryAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationAmendmentSummaryAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.History.ReservationAmendmentSummary> GetReservationAmendmentSummaryAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationAmendmentSummary, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateVehiclePlateInformation(global::HOLMS.Types.Booking.RPC.VehiclePlateInformationUpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateVehiclePlateInformation(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateVehiclePlateInformation(global::HOLMS.Types.Booking.RPC.VehiclePlateInformationUpdateRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateVehiclePlateInformation, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateVehiclePlateInformationAsync(global::HOLMS.Types.Booking.RPC.VehiclePlateInformationUpdateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateVehiclePlateInformationAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateVehiclePlateInformationAsync(global::HOLMS.Types.Booking.RPC.VehiclePlateInformationUpdateRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateVehiclePlateInformation, null, options, request);
      }
      protected override OpenLodgingReservationSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OpenLodgingReservationSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(OpenLodgingReservationSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetReservationHistory, serviceImpl.GetReservationHistory)
          .AddMethod(__Method_UpdateRoomAssignments, serviceImpl.UpdateRoomAssignments)
          .AddMethod(__Method_GetRoomAssignments, serviceImpl.GetRoomAssignments)
          .AddMethod(__Method_GetReservationContacts, serviceImpl.GetReservationContacts)
          .AddMethod(__Method_RemoveReservationContact, serviceImpl.RemoveReservationContact)
          .AddMethod(__Method_AddContactPerson, serviceImpl.AddContactPerson)
          .AddMethod(__Method_SetHousekeepingTimePreference, serviceImpl.SetHousekeepingTimePreference)
          .AddMethod(__Method_GetRecommendedCheckinAuthorizationAmounts, serviceImpl.GetRecommendedCheckinAuthorizationAmounts)
          .AddMethod(__Method_GetReservationAssociatedParties, serviceImpl.GetReservationAssociatedParties)
          .AddMethod(__Method_GetReservationCreationSummary, serviceImpl.GetReservationCreationSummary)
          .AddMethod(__Method_GetReservationAmendmentSummary, serviceImpl.GetReservationAmendmentSummary)
          .AddMethod(__Method_UpdateVehiclePlateInformation, serviceImpl.UpdateVehiclePlateInformation).Build();
    }

  }
}
#endregion
