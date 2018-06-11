// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/rpc/reservation_defaults_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.TenancyConfig.RPC {
  public static partial class ReservationDefaultsSvc
  {
    static readonly string __ServiceName = "holms.types.tenancy_config.rpc.ReservationDefaultsSvc";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.TenancyConfig.ReservationDefaults> __Marshaller_ReservationDefaults = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.ReservationDefaults.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.ReservationDefaults> __Method_Get = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.ReservationDefaults>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_Empty,
        __Marshaller_ReservationDefaults);

    static readonly grpc::Method<global::HOLMS.Types.TenancyConfig.ReservationDefaults, global::HOLMS.Types.TenancyConfig.ReservationDefaults> __Method_Set = new grpc::Method<global::HOLMS.Types.TenancyConfig.ReservationDefaults, global::HOLMS.Types.TenancyConfig.ReservationDefaults>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Set",
        __Marshaller_ReservationDefaults,
        __Marshaller_ReservationDefaults);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.TenancyConfig.RPC.ReservationDefaultsSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ReservationDefaultsSvc</summary>
    public abstract partial class ReservationDefaultsSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.ReservationDefaults> Get(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.ReservationDefaults> Set(global::HOLMS.Types.TenancyConfig.ReservationDefaults request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ReservationDefaultsSvc</summary>
    public partial class ReservationDefaultsSvcClient : grpc::ClientBase<ReservationDefaultsSvcClient>
    {
      /// <summary>Creates a new client for ReservationDefaultsSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ReservationDefaultsSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReservationDefaultsSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ReservationDefaultsSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ReservationDefaultsSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ReservationDefaultsSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.TenancyConfig.ReservationDefaults Get(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.ReservationDefaults Get(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ReservationDefaults> GetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ReservationDefaults> GetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      public virtual global::HOLMS.Types.TenancyConfig.ReservationDefaults Set(global::HOLMS.Types.TenancyConfig.ReservationDefaults request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Set(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.ReservationDefaults Set(global::HOLMS.Types.TenancyConfig.ReservationDefaults request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Set, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ReservationDefaults> SetAsync(global::HOLMS.Types.TenancyConfig.ReservationDefaults request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ReservationDefaults> SetAsync(global::HOLMS.Types.TenancyConfig.ReservationDefaults request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Set, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ReservationDefaultsSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReservationDefaultsSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ReservationDefaultsSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_Set, serviceImpl.Set).Build();
    }

  }
}
#endregion
