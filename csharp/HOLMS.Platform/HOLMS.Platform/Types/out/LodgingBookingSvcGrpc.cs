// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/lodging_booking_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.Booking.RPC {
  public static partial class LodgingBookingSvc
  {
    static readonly string __ServiceName = "holms.types.booking.rpc.LodgingBookingSvc";

    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Reservations.BookGenesisReservationRequest> __Marshaller_BookGenesisReservationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.BookGenesisReservationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Reservations.GenesisBookingResult> __Marshaller_GenesisBookingResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.GenesisBookingResult.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Indicators.ReservationIndicator> __Marshaller_ReservationIndicator = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Indicators.ReservationIndicator.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Reservations.CompleteOpenReservation> __Marshaller_CompleteOpenReservation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.CompleteOpenReservation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest> __Marshaller_AddGuestToReservationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Reservations.RemoveGuestFromReservationRequest> __Marshaller_RemoveGuestFromReservationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.RemoveGuestFromReservationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Reservations.ReservationFRPAmendmentRequest> __Marshaller_ReservationFRPAmendmentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.ReservationFRPAmendmentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse> __Marshaller_FRPAmendmentResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Reservations.ReservationChannelAmendmentRequest> __Marshaller_ReservationChannelAmendmentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.ReservationChannelAmendmentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.RPC.GetReservationNamesRequest> __Marshaller_GetReservationNamesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.GetReservationNamesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.RPC.ReservationNamesResponse> __Marshaller_ReservationNamesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.ReservationNamesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.RPC.SwapChargesRequest> __Marshaller_SwapChargesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.SwapChargesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.RPC.SwapChargesResponse> __Marshaller_SwapChargesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.SwapChargesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.RPC.SourceOfReservationRequest> __Marshaller_SourceOfReservationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.SourceOfReservationRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Reservations.BookGenesisReservationRequest, global::HOLMS.Types.Booking.Reservations.GenesisBookingResult> __Method_BookGenesisReservation = new grpc::Method<global::HOLMS.Types.Booking.Reservations.BookGenesisReservationRequest, global::HOLMS.Types.Booking.Reservations.GenesisBookingResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BookGenesisReservation",
        __Marshaller_BookGenesisReservationRequest,
        __Marshaller_GenesisBookingResult);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.Reservations.CompleteOpenReservation> __Method_GetOpenReservation = new grpc::Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.Reservations.CompleteOpenReservation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOpenReservation",
        __Marshaller_ReservationIndicator,
        __Marshaller_CompleteOpenReservation);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RequestAddGuestToReservation = new grpc::Method<global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestAddGuestToReservation",
        __Marshaller_AddGuestToReservationRequest,
        __Marshaller_Empty);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Reservations.RemoveGuestFromReservationRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RequestRemoveGuestFromReservation = new grpc::Method<global::HOLMS.Types.Booking.Reservations.RemoveGuestFromReservationRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestRemoveGuestFromReservation",
        __Marshaller_RemoveGuestFromReservationRequest,
        __Marshaller_Empty);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Reservations.ReservationFRPAmendmentRequest, global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse> __Method_AmendOpenReservationParameters = new grpc::Method<global::HOLMS.Types.Booking.Reservations.ReservationFRPAmendmentRequest, global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AmendOpenReservationParameters",
        __Marshaller_ReservationFRPAmendmentRequest,
        __Marshaller_FRPAmendmentResponse);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RequestChangePrimaryGuestInReservation = new grpc::Method<global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestChangePrimaryGuestInReservation",
        __Marshaller_AddGuestToReservationRequest,
        __Marshaller_Empty);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Reservations.ReservationChannelAmendmentRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RequestUpdateChannelDetailsReservation = new grpc::Method<global::HOLMS.Types.Booking.Reservations.ReservationChannelAmendmentRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestUpdateChannelDetailsReservation",
        __Marshaller_ReservationChannelAmendmentRequest,
        __Marshaller_Empty);

    static readonly grpc::Method<global::HOLMS.Types.Booking.RPC.GetReservationNamesRequest, global::HOLMS.Types.Booking.RPC.ReservationNamesResponse> __Method_GetReservationNames = new grpc::Method<global::HOLMS.Types.Booking.RPC.GetReservationNamesRequest, global::HOLMS.Types.Booking.RPC.ReservationNamesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetReservationNames",
        __Marshaller_GetReservationNamesRequest,
        __Marshaller_ReservationNamesResponse);

    static readonly grpc::Method<global::HOLMS.Types.Booking.RPC.SwapChargesRequest, global::HOLMS.Types.Booking.RPC.SwapChargesResponse> __Method_SwapExtraStayCharges = new grpc::Method<global::HOLMS.Types.Booking.RPC.SwapChargesRequest, global::HOLMS.Types.Booking.RPC.SwapChargesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SwapExtraStayCharges",
        __Marshaller_SwapChargesRequest,
        __Marshaller_SwapChargesResponse);

    static readonly grpc::Method<global::HOLMS.Types.Booking.RPC.SourceOfReservationRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetSourceOfReservation = new grpc::Method<global::HOLMS.Types.Booking.RPC.SourceOfReservationRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetSourceOfReservation",
        __Marshaller_SourceOfReservationRequest,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Booking.RPC.LodgingBookingSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LodgingBookingSvc</summary>
    public abstract partial class LodgingBookingSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.Reservations.GenesisBookingResult> BookGenesisReservation(global::HOLMS.Types.Booking.Reservations.BookGenesisReservationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.Reservations.CompleteOpenReservation> GetOpenReservation(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> RequestAddGuestToReservation(global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> RequestRemoveGuestFromReservation(global::HOLMS.Types.Booking.Reservations.RemoveGuestFromReservationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse> AmendOpenReservationParameters(global::HOLMS.Types.Booking.Reservations.ReservationFRPAmendmentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> RequestChangePrimaryGuestInReservation(global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> RequestUpdateChannelDetailsReservation(global::HOLMS.Types.Booking.Reservations.ReservationChannelAmendmentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ReservationNamesResponse> GetReservationNames(global::HOLMS.Types.Booking.RPC.GetReservationNamesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.SwapChargesResponse> SwapExtraStayCharges(global::HOLMS.Types.Booking.RPC.SwapChargesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> SetSourceOfReservation(global::HOLMS.Types.Booking.RPC.SourceOfReservationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for LodgingBookingSvc</summary>
    public partial class LodgingBookingSvcClient : grpc::ClientBase<LodgingBookingSvcClient>
    {
      /// <summary>Creates a new client for LodgingBookingSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LodgingBookingSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LodgingBookingSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LodgingBookingSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LodgingBookingSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LodgingBookingSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Booking.Reservations.GenesisBookingResult BookGenesisReservation(global::HOLMS.Types.Booking.Reservations.BookGenesisReservationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return BookGenesisReservation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.Reservations.GenesisBookingResult BookGenesisReservation(global::HOLMS.Types.Booking.Reservations.BookGenesisReservationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BookGenesisReservation, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.Reservations.GenesisBookingResult> BookGenesisReservationAsync(global::HOLMS.Types.Booking.Reservations.BookGenesisReservationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return BookGenesisReservationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.Reservations.GenesisBookingResult> BookGenesisReservationAsync(global::HOLMS.Types.Booking.Reservations.BookGenesisReservationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BookGenesisReservation, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.Reservations.CompleteOpenReservation GetOpenReservation(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetOpenReservation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.Reservations.CompleteOpenReservation GetOpenReservation(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetOpenReservation, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.Reservations.CompleteOpenReservation> GetOpenReservationAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetOpenReservationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.Reservations.CompleteOpenReservation> GetOpenReservationAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetOpenReservation, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RequestAddGuestToReservation(global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestAddGuestToReservation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RequestAddGuestToReservation(global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestAddGuestToReservation, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RequestAddGuestToReservationAsync(global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestAddGuestToReservationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RequestAddGuestToReservationAsync(global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestAddGuestToReservation, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RequestRemoveGuestFromReservation(global::HOLMS.Types.Booking.Reservations.RemoveGuestFromReservationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestRemoveGuestFromReservation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RequestRemoveGuestFromReservation(global::HOLMS.Types.Booking.Reservations.RemoveGuestFromReservationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestRemoveGuestFromReservation, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RequestRemoveGuestFromReservationAsync(global::HOLMS.Types.Booking.Reservations.RemoveGuestFromReservationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestRemoveGuestFromReservationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RequestRemoveGuestFromReservationAsync(global::HOLMS.Types.Booking.Reservations.RemoveGuestFromReservationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestRemoveGuestFromReservation, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse AmendOpenReservationParameters(global::HOLMS.Types.Booking.Reservations.ReservationFRPAmendmentRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AmendOpenReservationParameters(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse AmendOpenReservationParameters(global::HOLMS.Types.Booking.Reservations.ReservationFRPAmendmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AmendOpenReservationParameters, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse> AmendOpenReservationParametersAsync(global::HOLMS.Types.Booking.Reservations.ReservationFRPAmendmentRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AmendOpenReservationParametersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse> AmendOpenReservationParametersAsync(global::HOLMS.Types.Booking.Reservations.ReservationFRPAmendmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AmendOpenReservationParameters, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RequestChangePrimaryGuestInReservation(global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestChangePrimaryGuestInReservation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RequestChangePrimaryGuestInReservation(global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestChangePrimaryGuestInReservation, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RequestChangePrimaryGuestInReservationAsync(global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestChangePrimaryGuestInReservationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RequestChangePrimaryGuestInReservationAsync(global::HOLMS.Types.Booking.Reservations.AddGuestToReservationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestChangePrimaryGuestInReservation, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RequestUpdateChannelDetailsReservation(global::HOLMS.Types.Booking.Reservations.ReservationChannelAmendmentRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestUpdateChannelDetailsReservation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RequestUpdateChannelDetailsReservation(global::HOLMS.Types.Booking.Reservations.ReservationChannelAmendmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestUpdateChannelDetailsReservation, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RequestUpdateChannelDetailsReservationAsync(global::HOLMS.Types.Booking.Reservations.ReservationChannelAmendmentRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestUpdateChannelDetailsReservationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RequestUpdateChannelDetailsReservationAsync(global::HOLMS.Types.Booking.Reservations.ReservationChannelAmendmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestUpdateChannelDetailsReservation, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationNamesResponse GetReservationNames(global::HOLMS.Types.Booking.RPC.GetReservationNamesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationNames(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationNamesResponse GetReservationNames(global::HOLMS.Types.Booking.RPC.GetReservationNamesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationNames, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationNamesResponse> GetReservationNamesAsync(global::HOLMS.Types.Booking.RPC.GetReservationNamesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationNamesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationNamesResponse> GetReservationNamesAsync(global::HOLMS.Types.Booking.RPC.GetReservationNamesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationNames, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.SwapChargesResponse SwapExtraStayCharges(global::HOLMS.Types.Booking.RPC.SwapChargesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SwapExtraStayCharges(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.SwapChargesResponse SwapExtraStayCharges(global::HOLMS.Types.Booking.RPC.SwapChargesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SwapExtraStayCharges, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.SwapChargesResponse> SwapExtraStayChargesAsync(global::HOLMS.Types.Booking.RPC.SwapChargesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SwapExtraStayChargesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.SwapChargesResponse> SwapExtraStayChargesAsync(global::HOLMS.Types.Booking.RPC.SwapChargesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SwapExtraStayCharges, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetSourceOfReservation(global::HOLMS.Types.Booking.RPC.SourceOfReservationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetSourceOfReservation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetSourceOfReservation(global::HOLMS.Types.Booking.RPC.SourceOfReservationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetSourceOfReservation, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SetSourceOfReservationAsync(global::HOLMS.Types.Booking.RPC.SourceOfReservationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetSourceOfReservationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SetSourceOfReservationAsync(global::HOLMS.Types.Booking.RPC.SourceOfReservationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetSourceOfReservation, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LodgingBookingSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LodgingBookingSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(LodgingBookingSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_BookGenesisReservation, serviceImpl.BookGenesisReservation)
          .AddMethod(__Method_GetOpenReservation, serviceImpl.GetOpenReservation)
          .AddMethod(__Method_RequestAddGuestToReservation, serviceImpl.RequestAddGuestToReservation)
          .AddMethod(__Method_RequestRemoveGuestFromReservation, serviceImpl.RequestRemoveGuestFromReservation)
          .AddMethod(__Method_AmendOpenReservationParameters, serviceImpl.AmendOpenReservationParameters)
          .AddMethod(__Method_RequestChangePrimaryGuestInReservation, serviceImpl.RequestChangePrimaryGuestInReservation)
          .AddMethod(__Method_RequestUpdateChannelDetailsReservation, serviceImpl.RequestUpdateChannelDetailsReservation)
          .AddMethod(__Method_GetReservationNames, serviceImpl.GetReservationNames)
          .AddMethod(__Method_SwapExtraStayCharges, serviceImpl.SwapExtraStayCharges)
          .AddMethod(__Method_SetSourceOfReservation, serviceImpl.SetSourceOfReservation).Build();
    }

  }
}
#endregion
