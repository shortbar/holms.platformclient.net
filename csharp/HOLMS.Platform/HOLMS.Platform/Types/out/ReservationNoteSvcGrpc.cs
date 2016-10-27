// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/reservation_note_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Booking.RPC {
  public static class ReservationNoteSvc
  {
    static readonly string __ServiceName = "holms.types.booking.rpc.ReservationNoteSvc";

    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.ReservationNoteFulfillmentRequest> __Marshaller_ReservationNoteFulfillmentRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.ReservationNoteFulfillmentRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.Indicators.ReservationIndicator> __Marshaller_ReservationIndicator = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Indicators.ReservationIndicator.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.ReservationNoteSvcGetNotesResponse> __Marshaller_ReservationNoteSvcGetNotesResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.ReservationNoteSvcGetNotesResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.Reservations.ReservationNote> __Marshaller_ReservationNote = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.ReservationNote.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator> __Marshaller_ReservationNoteIndicator = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.Booking.RPC.ReservationNoteFulfillmentRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetNoteFulfillment = new Method<global::HOLMS.Types.Booking.RPC.ReservationNoteFulfillmentRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "SetNoteFulfillment",
        __Marshaller_ReservationNoteFulfillmentRequest,
        __Marshaller_Empty);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.RPC.ReservationNoteSvcGetNotesResponse> __Method_GetReservationNotes = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.RPC.ReservationNoteSvcGetNotesResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetReservationNotes",
        __Marshaller_ReservationIndicator,
        __Marshaller_ReservationNoteSvcGetNotesResponse);

    static readonly Method<global::HOLMS.Types.Booking.Reservations.ReservationNote, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddReservationNote = new Method<global::HOLMS.Types.Booking.Reservations.ReservationNote, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "AddReservationNote",
        __Marshaller_ReservationNote,
        __Marshaller_Empty);

    static readonly Method<global::HOLMS.Types.Booking.Reservations.ReservationNote, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateReservationNote = new Method<global::HOLMS.Types.Booking.Reservations.ReservationNote, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "UpdateReservationNote",
        __Marshaller_ReservationNote,
        __Marshaller_Empty);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveReservationNote = new Method<global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "RemoveReservationNote",
        __Marshaller_ReservationNoteIndicator,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Booking.RPC.ReservationNoteSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ReservationNoteSvc</summary>
    public abstract class ReservationNoteSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> SetNoteFulfillment(global::HOLMS.Types.Booking.RPC.ReservationNoteFulfillmentRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ReservationNoteSvcGetNotesResponse> GetReservationNotes(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AddReservationNote(global::HOLMS.Types.Booking.Reservations.ReservationNote request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateReservationNote(global::HOLMS.Types.Booking.Reservations.ReservationNote request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> RemoveReservationNote(global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ReservationNoteSvc</summary>
    public class ReservationNoteSvcClient : ClientBase<ReservationNoteSvcClient>
    {
      /// <summary>Creates a new client for ReservationNoteSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ReservationNoteSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReservationNoteSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ReservationNoteSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ReservationNoteSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ReservationNoteSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetNoteFulfillment(global::HOLMS.Types.Booking.RPC.ReservationNoteFulfillmentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetNoteFulfillment(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetNoteFulfillment(global::HOLMS.Types.Booking.RPC.ReservationNoteFulfillmentRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetNoteFulfillment, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SetNoteFulfillmentAsync(global::HOLMS.Types.Booking.RPC.ReservationNoteFulfillmentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetNoteFulfillmentAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SetNoteFulfillmentAsync(global::HOLMS.Types.Booking.RPC.ReservationNoteFulfillmentRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetNoteFulfillment, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationNoteSvcGetNotesResponse GetReservationNotes(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationNotes(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationNoteSvcGetNotesResponse GetReservationNotes(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationNotes, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationNoteSvcGetNotesResponse> GetReservationNotesAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationNotesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationNoteSvcGetNotesResponse> GetReservationNotesAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationNotes, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddReservationNote(global::HOLMS.Types.Booking.Reservations.ReservationNote request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddReservationNote(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddReservationNote(global::HOLMS.Types.Booking.Reservations.ReservationNote request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddReservationNote, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddReservationNoteAsync(global::HOLMS.Types.Booking.Reservations.ReservationNote request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddReservationNoteAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddReservationNoteAsync(global::HOLMS.Types.Booking.Reservations.ReservationNote request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddReservationNote, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateReservationNote(global::HOLMS.Types.Booking.Reservations.ReservationNote request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateReservationNote(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateReservationNote(global::HOLMS.Types.Booking.Reservations.ReservationNote request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateReservationNote, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateReservationNoteAsync(global::HOLMS.Types.Booking.Reservations.ReservationNote request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateReservationNoteAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateReservationNoteAsync(global::HOLMS.Types.Booking.Reservations.ReservationNote request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateReservationNote, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveReservationNote(global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveReservationNote(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveReservationNote(global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoveReservationNote, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RemoveReservationNoteAsync(global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveReservationNoteAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RemoveReservationNoteAsync(global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoveReservationNote, null, options, request);
      }
      protected override ReservationNoteSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReservationNoteSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ReservationNoteSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SetNoteFulfillment, serviceImpl.SetNoteFulfillment)
          .AddMethod(__Method_GetReservationNotes, serviceImpl.GetReservationNotes)
          .AddMethod(__Method_AddReservationNote, serviceImpl.AddReservationNote)
          .AddMethod(__Method_UpdateReservationNote, serviceImpl.UpdateReservationNote)
          .AddMethod(__Method_RemoveReservationNote, serviceImpl.RemoveReservationNote).Build();
    }

  }
}
#endregion
