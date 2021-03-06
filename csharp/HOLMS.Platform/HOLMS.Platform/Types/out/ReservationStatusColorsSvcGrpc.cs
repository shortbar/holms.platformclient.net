// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/rpc/reservation_status_colors_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.TenancyConfig.RPC {
  public static partial class ReservationStatusColorsSvc
  {
    static readonly string __ServiceName = "holms.types.tenancy_config.rpc.ReservationStatusColorsSvc";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.TenancyConfig.ReservationStatusColors> __Marshaller_ReservationStatusColors = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.ReservationStatusColors.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.ReservationStatusColors> __Method_Get = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.ReservationStatusColors>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_Empty,
        __Marshaller_ReservationStatusColors);

    static readonly grpc::Method<global::HOLMS.Types.TenancyConfig.ReservationStatusColors, global::HOLMS.Types.TenancyConfig.ReservationStatusColors> __Method_Set = new grpc::Method<global::HOLMS.Types.TenancyConfig.ReservationStatusColors, global::HOLMS.Types.TenancyConfig.ReservationStatusColors>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Set",
        __Marshaller_ReservationStatusColors,
        __Marshaller_ReservationStatusColors);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.TenancyConfig.RPC.ReservationStatusColorsSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ReservationStatusColorsSvc</summary>
    public abstract partial class ReservationStatusColorsSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.ReservationStatusColors> Get(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.ReservationStatusColors> Set(global::HOLMS.Types.TenancyConfig.ReservationStatusColors request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ReservationStatusColorsSvc</summary>
    public partial class ReservationStatusColorsSvcClient : grpc::ClientBase<ReservationStatusColorsSvcClient>
    {
      /// <summary>Creates a new client for ReservationStatusColorsSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ReservationStatusColorsSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReservationStatusColorsSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ReservationStatusColorsSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ReservationStatusColorsSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ReservationStatusColorsSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.TenancyConfig.ReservationStatusColors Get(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.ReservationStatusColors Get(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ReservationStatusColors> GetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ReservationStatusColors> GetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      public virtual global::HOLMS.Types.TenancyConfig.ReservationStatusColors Set(global::HOLMS.Types.TenancyConfig.ReservationStatusColors request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Set(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.ReservationStatusColors Set(global::HOLMS.Types.TenancyConfig.ReservationStatusColors request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Set, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ReservationStatusColors> SetAsync(global::HOLMS.Types.TenancyConfig.ReservationStatusColors request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ReservationStatusColors> SetAsync(global::HOLMS.Types.TenancyConfig.ReservationStatusColors request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Set, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ReservationStatusColorsSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReservationStatusColorsSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ReservationStatusColorsSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_Set, serviceImpl.Set).Build();
    }

  }
}
#endregion
