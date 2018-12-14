// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/ota_sync_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.Booking.RPC {
  public static partial class OTASyncSvc
  {
    static readonly string __ServiceName = "holms.types.booking.rpc.OTASyncSvc";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.RPC.ServerTaskDetails> __Marshaller_ServerTaskDetails = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.ServerTaskDetails.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.RPC.SchedulerStartAttemptResponse> __Marshaller_SchedulerStartAttemptResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.SchedulerStartAttemptResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SyncReservations = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SyncReservations",
        __Marshaller_Empty,
        __Marshaller_Empty);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Booking.RPC.ServerTaskDetails> __Method_GetSchedulerLastWorkingTime = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Booking.RPC.ServerTaskDetails>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSchedulerLastWorkingTime",
        __Marshaller_Empty,
        __Marshaller_ServerTaskDetails);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Booking.RPC.SchedulerStartAttemptResponse> __Method_AttemptStartScheduler = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Booking.RPC.SchedulerStartAttemptResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AttemptStartScheduler",
        __Marshaller_Empty,
        __Marshaller_SchedulerStartAttemptResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Booking.RPC.OtaSyncSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of OTASyncSvc</summary>
    public abstract partial class OTASyncSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> SyncReservations(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ServerTaskDetails> GetSchedulerLastWorkingTime(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.SchedulerStartAttemptResponse> AttemptStartScheduler(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for OTASyncSvc</summary>
    public partial class OTASyncSvcClient : grpc::ClientBase<OTASyncSvcClient>
    {
      /// <summary>Creates a new client for OTASyncSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OTASyncSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OTASyncSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OTASyncSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OTASyncSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OTASyncSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty SyncReservations(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SyncReservations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SyncReservations(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SyncReservations, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SyncReservationsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SyncReservationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SyncReservationsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SyncReservations, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.ServerTaskDetails GetSchedulerLastWorkingTime(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetSchedulerLastWorkingTime(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.ServerTaskDetails GetSchedulerLastWorkingTime(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSchedulerLastWorkingTime, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ServerTaskDetails> GetSchedulerLastWorkingTimeAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetSchedulerLastWorkingTimeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ServerTaskDetails> GetSchedulerLastWorkingTimeAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSchedulerLastWorkingTime, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.SchedulerStartAttemptResponse AttemptStartScheduler(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AttemptStartScheduler(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.SchedulerStartAttemptResponse AttemptStartScheduler(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AttemptStartScheduler, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.SchedulerStartAttemptResponse> AttemptStartSchedulerAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AttemptStartSchedulerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.SchedulerStartAttemptResponse> AttemptStartSchedulerAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AttemptStartScheduler, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OTASyncSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OTASyncSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(OTASyncSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SyncReservations, serviceImpl.SyncReservations)
          .AddMethod(__Method_GetSchedulerLastWorkingTime, serviceImpl.GetSchedulerLastWorkingTime)
          .AddMethod(__Method_AttemptStartScheduler, serviceImpl.AttemptStartScheduler).Build();
    }

  }
}
#endregion
