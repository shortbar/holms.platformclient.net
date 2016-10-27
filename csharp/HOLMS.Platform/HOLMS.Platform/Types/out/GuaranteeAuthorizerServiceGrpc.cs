// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/guarantee_authorizer_service.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Booking.RPC {
  public static class GuaranteeAuthorizerService
  {
    static readonly string __ServiceName = "holms.types.booking.rpc.GuaranteeAuthorizerService";

    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AuthorizeForTenancy = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "AuthorizeForTenancy",
        __Marshaller_Empty,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Booking.RPC.GuaranteeAuthorizerServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GuaranteeAuthorizerService</summary>
    public abstract class GuaranteeAuthorizerServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AuthorizeForTenancy(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GuaranteeAuthorizerService</summary>
    public class GuaranteeAuthorizerServiceClient : ClientBase<GuaranteeAuthorizerServiceClient>
    {
      /// <summary>Creates a new client for GuaranteeAuthorizerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GuaranteeAuthorizerServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GuaranteeAuthorizerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GuaranteeAuthorizerServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GuaranteeAuthorizerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GuaranteeAuthorizerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty AuthorizeForTenancy(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AuthorizeForTenancy(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AuthorizeForTenancy(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AuthorizeForTenancy, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AuthorizeForTenancyAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AuthorizeForTenancyAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AuthorizeForTenancyAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AuthorizeForTenancy, null, options, request);
      }
      protected override GuaranteeAuthorizerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GuaranteeAuthorizerServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(GuaranteeAuthorizerServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AuthorizeForTenancy, serviceImpl.AuthorizeForTenancy).Build();
    }

  }
}
#endregion
