// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/rpc/incidental_supply_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.Supply.RPC {
  public static partial class IncidentalSupplySvc
  {
    static readonly string __ServiceName = "holms.types.supply.rpc.IncidentalSupplySvc";

    static readonly grpc::Marshaller<global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityQuery> __Marshaller_IncidentalItemAvailabilityQuery = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityQuery.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityResponse> __Marshaller_IncidentalItemAvailabilityResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityQuery, global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityResponse> __Method_CheckAvailability = new grpc::Method<global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityQuery, global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckAvailability",
        __Marshaller_IncidentalItemAvailabilityQuery,
        __Marshaller_IncidentalItemAvailabilityResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Supply.RPC.IncidentalSupplySvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of IncidentalSupplySvc</summary>
    public abstract partial class IncidentalSupplySvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityResponse> CheckAvailability(global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityQuery request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for IncidentalSupplySvc</summary>
    public partial class IncidentalSupplySvcClient : grpc::ClientBase<IncidentalSupplySvcClient>
    {
      /// <summary>Creates a new client for IncidentalSupplySvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public IncidentalSupplySvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for IncidentalSupplySvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public IncidentalSupplySvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected IncidentalSupplySvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected IncidentalSupplySvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityResponse CheckAvailability(global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityQuery request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CheckAvailability(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityResponse CheckAvailability(global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityQuery request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckAvailability, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityResponse> CheckAvailabilityAsync(global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityQuery request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CheckAvailabilityAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityResponse> CheckAvailabilityAsync(global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemAvailabilityQuery request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckAvailability, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override IncidentalSupplySvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new IncidentalSupplySvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(IncidentalSupplySvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CheckAvailability, serviceImpl.CheckAvailability).Build();
    }

  }
}
#endregion
