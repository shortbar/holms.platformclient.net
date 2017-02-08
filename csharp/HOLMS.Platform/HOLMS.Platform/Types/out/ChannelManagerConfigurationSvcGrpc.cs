// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/rpc/channel_manager_configuration_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.TenancyConfig.RPC {
  public static class ChannelManagerConfigurationSvc
  {
    static readonly string __ServiceName = "holms.types.tenancy_config.rpc.ChannelManagerConfigurationSvc";

    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.ChannelManagerConfig> __Marshaller_ChannelManagerConfig = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.ChannelManagerConfig.Parser.ParseFrom);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.ChannelManagerConfig> __Method_Get = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.ChannelManagerConfig>(
        MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_Empty,
        __Marshaller_ChannelManagerConfig);

    static readonly Method<global::HOLMS.Types.TenancyConfig.ChannelManagerConfig, global::HOLMS.Types.TenancyConfig.ChannelManagerConfig> __Method_Set = new Method<global::HOLMS.Types.TenancyConfig.ChannelManagerConfig, global::HOLMS.Types.TenancyConfig.ChannelManagerConfig>(
        MethodType.Unary,
        __ServiceName,
        "Set",
        __Marshaller_ChannelManagerConfig,
        __Marshaller_ChannelManagerConfig);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.TenancyConfig.RPC.ChannelManagerConfigurationSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ChannelManagerConfigurationSvc</summary>
    public abstract class ChannelManagerConfigurationSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.ChannelManagerConfig> Get(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.ChannelManagerConfig> Set(global::HOLMS.Types.TenancyConfig.ChannelManagerConfig request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ChannelManagerConfigurationSvc</summary>
    public class ChannelManagerConfigurationSvcClient : ClientBase<ChannelManagerConfigurationSvcClient>
    {
      /// <summary>Creates a new client for ChannelManagerConfigurationSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ChannelManagerConfigurationSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ChannelManagerConfigurationSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ChannelManagerConfigurationSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ChannelManagerConfigurationSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ChannelManagerConfigurationSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.TenancyConfig.ChannelManagerConfig Get(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Get(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.ChannelManagerConfig Get(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ChannelManagerConfig> GetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ChannelManagerConfig> GetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      public virtual global::HOLMS.Types.TenancyConfig.ChannelManagerConfig Set(global::HOLMS.Types.TenancyConfig.ChannelManagerConfig request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Set(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.ChannelManagerConfig Set(global::HOLMS.Types.TenancyConfig.ChannelManagerConfig request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Set, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ChannelManagerConfig> SetAsync(global::HOLMS.Types.TenancyConfig.ChannelManagerConfig request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.ChannelManagerConfig> SetAsync(global::HOLMS.Types.TenancyConfig.ChannelManagerConfig request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Set, null, options, request);
      }
      protected override ChannelManagerConfigurationSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ChannelManagerConfigurationSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ChannelManagerConfigurationSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_Set, serviceImpl.Set).Build();
    }

  }
}
#endregion
