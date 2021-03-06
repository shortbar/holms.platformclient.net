// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/rpc/master_folio_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.Folio.RPC {
  public static partial class MasterFolioSvc
  {
    static readonly string __ServiceName = "holms.types.folio.rpc.MasterFolioSvc";

    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.MasterFolioServiceMasterFolioRequest> __Marshaller_MasterFolioServiceMasterFolioRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.MasterFolioServiceMasterFolioRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.MasterFolioServiceRequestMasterFolioResponse> __Marshaller_MasterFolioServiceRequestMasterFolioResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.MasterFolioServiceRequestMasterFolioResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest> __Marshaller_MasterFolioSvcRemoveMasterFolioRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.MasterFolioServiceRemoveMasterFolioResponse> __Marshaller_MasterFolioServiceRemoveMasterFolioResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.MasterFolioServiceRemoveMasterFolioResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.MasterFolioServiceFolioSwapRequest> __Marshaller_MasterFolioServiceFolioSwapRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.MasterFolioServiceFolioSwapRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.MasterFolioSvcFolioSwapResponse> __Marshaller_MasterFolioSvcFolioSwapResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.MasterFolioSvcFolioSwapResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckRequest> __Marshaller_LinkMasterAuthorizationCheckRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckResponse> __Marshaller_LinkMasterAuthorizationCheckResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.UpdateClientFoliosRequest> __Marshaller_UpdateClientFoliosRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.UpdateClientFoliosRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.UpdateClientFoliosResponse> __Marshaller_UpdateClientFoliosResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.UpdateClientFoliosResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckRequest> __Marshaller_IsMasterPaysCheckRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckResponse> __Marshaller_IsMasterPaysCheckResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::HOLMS.Types.Folio.RPC.MasterFolioServiceMasterFolioRequest, global::HOLMS.Types.Folio.RPC.MasterFolioServiceRequestMasterFolioResponse> __Method_RequestMasterFolio = new grpc::Method<global::HOLMS.Types.Folio.RPC.MasterFolioServiceMasterFolioRequest, global::HOLMS.Types.Folio.RPC.MasterFolioServiceRequestMasterFolioResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestMasterFolio",
        __Marshaller_MasterFolioServiceMasterFolioRequest,
        __Marshaller_MasterFolioServiceRequestMasterFolioResponse);

    static readonly grpc::Method<global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest, global::HOLMS.Types.Folio.RPC.MasterFolioServiceRemoveMasterFolioResponse> __Method_RemoveMasterFolio = new grpc::Method<global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest, global::HOLMS.Types.Folio.RPC.MasterFolioServiceRemoveMasterFolioResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RemoveMasterFolio",
        __Marshaller_MasterFolioSvcRemoveMasterFolioRequest,
        __Marshaller_MasterFolioServiceRemoveMasterFolioResponse);

    static readonly grpc::Method<global::HOLMS.Types.Folio.RPC.MasterFolioServiceFolioSwapRequest, global::HOLMS.Types.Folio.RPC.MasterFolioSvcFolioSwapResponse> __Method_AtomicFolioChargeSwap = new grpc::Method<global::HOLMS.Types.Folio.RPC.MasterFolioServiceFolioSwapRequest, global::HOLMS.Types.Folio.RPC.MasterFolioSvcFolioSwapResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AtomicFolioChargeSwap",
        __Marshaller_MasterFolioServiceFolioSwapRequest,
        __Marshaller_MasterFolioSvcFolioSwapResponse);

    static readonly grpc::Method<global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckRequest, global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckResponse> __Method_AuthorizationIncrease = new grpc::Method<global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckRequest, global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AuthorizationIncrease",
        __Marshaller_LinkMasterAuthorizationCheckRequest,
        __Marshaller_LinkMasterAuthorizationCheckResponse);

    static readonly grpc::Method<global::HOLMS.Types.Folio.RPC.UpdateClientFoliosRequest, global::HOLMS.Types.Folio.RPC.UpdateClientFoliosResponse> __Method_UpdateClientFolios = new grpc::Method<global::HOLMS.Types.Folio.RPC.UpdateClientFoliosRequest, global::HOLMS.Types.Folio.RPC.UpdateClientFoliosResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateClientFolios",
        __Marshaller_UpdateClientFoliosRequest,
        __Marshaller_UpdateClientFoliosResponse);

    static readonly grpc::Method<global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckRequest, global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckResponse> __Method_IsMasterPaysCheck = new grpc::Method<global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckRequest, global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IsMasterPaysCheck",
        __Marshaller_IsMasterPaysCheckRequest,
        __Marshaller_IsMasterPaysCheckResponse);

    static readonly grpc::Method<global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveMasterOrGroupGuaranteeFromClient = new grpc::Method<global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RemoveMasterOrGroupGuaranteeFromClient",
        __Marshaller_MasterFolioSvcRemoveMasterFolioRequest,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Folio.RPC.MasterFolioSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MasterFolioSvc</summary>
    public abstract partial class MasterFolioSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Folio.RPC.MasterFolioServiceRequestMasterFolioResponse> RequestMasterFolio(global::HOLMS.Types.Folio.RPC.MasterFolioServiceMasterFolioRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Folio.RPC.MasterFolioServiceRemoveMasterFolioResponse> RemoveMasterFolio(global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Folio.RPC.MasterFolioSvcFolioSwapResponse> AtomicFolioChargeSwap(global::HOLMS.Types.Folio.RPC.MasterFolioServiceFolioSwapRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckResponse> AuthorizationIncrease(global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Folio.RPC.UpdateClientFoliosResponse> UpdateClientFolios(global::HOLMS.Types.Folio.RPC.UpdateClientFoliosRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckResponse> IsMasterPaysCheck(global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> RemoveMasterOrGroupGuaranteeFromClient(global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MasterFolioSvc</summary>
    public partial class MasterFolioSvcClient : grpc::ClientBase<MasterFolioSvcClient>
    {
      /// <summary>Creates a new client for MasterFolioSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MasterFolioSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MasterFolioSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MasterFolioSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MasterFolioSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MasterFolioSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Folio.RPC.MasterFolioServiceRequestMasterFolioResponse RequestMasterFolio(global::HOLMS.Types.Folio.RPC.MasterFolioServiceMasterFolioRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestMasterFolio(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Folio.RPC.MasterFolioServiceRequestMasterFolioResponse RequestMasterFolio(global::HOLMS.Types.Folio.RPC.MasterFolioServiceMasterFolioRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestMasterFolio, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.MasterFolioServiceRequestMasterFolioResponse> RequestMasterFolioAsync(global::HOLMS.Types.Folio.RPC.MasterFolioServiceMasterFolioRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestMasterFolioAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.MasterFolioServiceRequestMasterFolioResponse> RequestMasterFolioAsync(global::HOLMS.Types.Folio.RPC.MasterFolioServiceMasterFolioRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestMasterFolio, null, options, request);
      }
      public virtual global::HOLMS.Types.Folio.RPC.MasterFolioServiceRemoveMasterFolioResponse RemoveMasterFolio(global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveMasterFolio(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Folio.RPC.MasterFolioServiceRemoveMasterFolioResponse RemoveMasterFolio(global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoveMasterFolio, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.MasterFolioServiceRemoveMasterFolioResponse> RemoveMasterFolioAsync(global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveMasterFolioAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.MasterFolioServiceRemoveMasterFolioResponse> RemoveMasterFolioAsync(global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoveMasterFolio, null, options, request);
      }
      public virtual global::HOLMS.Types.Folio.RPC.MasterFolioSvcFolioSwapResponse AtomicFolioChargeSwap(global::HOLMS.Types.Folio.RPC.MasterFolioServiceFolioSwapRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AtomicFolioChargeSwap(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Folio.RPC.MasterFolioSvcFolioSwapResponse AtomicFolioChargeSwap(global::HOLMS.Types.Folio.RPC.MasterFolioServiceFolioSwapRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AtomicFolioChargeSwap, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.MasterFolioSvcFolioSwapResponse> AtomicFolioChargeSwapAsync(global::HOLMS.Types.Folio.RPC.MasterFolioServiceFolioSwapRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AtomicFolioChargeSwapAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.MasterFolioSvcFolioSwapResponse> AtomicFolioChargeSwapAsync(global::HOLMS.Types.Folio.RPC.MasterFolioServiceFolioSwapRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AtomicFolioChargeSwap, null, options, request);
      }
      public virtual global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckResponse AuthorizationIncrease(global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AuthorizationIncrease(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckResponse AuthorizationIncrease(global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AuthorizationIncrease, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckResponse> AuthorizationIncreaseAsync(global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AuthorizationIncreaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckResponse> AuthorizationIncreaseAsync(global::HOLMS.Types.Folio.RPC.LinkMasterAuthorizationCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AuthorizationIncrease, null, options, request);
      }
      public virtual global::HOLMS.Types.Folio.RPC.UpdateClientFoliosResponse UpdateClientFolios(global::HOLMS.Types.Folio.RPC.UpdateClientFoliosRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateClientFolios(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Folio.RPC.UpdateClientFoliosResponse UpdateClientFolios(global::HOLMS.Types.Folio.RPC.UpdateClientFoliosRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateClientFolios, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.UpdateClientFoliosResponse> UpdateClientFoliosAsync(global::HOLMS.Types.Folio.RPC.UpdateClientFoliosRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateClientFoliosAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.UpdateClientFoliosResponse> UpdateClientFoliosAsync(global::HOLMS.Types.Folio.RPC.UpdateClientFoliosRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateClientFolios, null, options, request);
      }
      public virtual global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckResponse IsMasterPaysCheck(global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return IsMasterPaysCheck(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckResponse IsMasterPaysCheck(global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_IsMasterPaysCheck, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckResponse> IsMasterPaysCheckAsync(global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return IsMasterPaysCheckAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckResponse> IsMasterPaysCheckAsync(global::HOLMS.Types.Folio.RPC.IsMasterPaysCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_IsMasterPaysCheck, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveMasterOrGroupGuaranteeFromClient(global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveMasterOrGroupGuaranteeFromClient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveMasterOrGroupGuaranteeFromClient(global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoveMasterOrGroupGuaranteeFromClient, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RemoveMasterOrGroupGuaranteeFromClientAsync(global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveMasterOrGroupGuaranteeFromClientAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RemoveMasterOrGroupGuaranteeFromClientAsync(global::HOLMS.Types.Folio.RPC.MasterFolioSvcRemoveMasterFolioRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoveMasterOrGroupGuaranteeFromClient, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MasterFolioSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MasterFolioSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MasterFolioSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RequestMasterFolio, serviceImpl.RequestMasterFolio)
          .AddMethod(__Method_RemoveMasterFolio, serviceImpl.RemoveMasterFolio)
          .AddMethod(__Method_AtomicFolioChargeSwap, serviceImpl.AtomicFolioChargeSwap)
          .AddMethod(__Method_AuthorizationIncrease, serviceImpl.AuthorizationIncrease)
          .AddMethod(__Method_UpdateClientFolios, serviceImpl.UpdateClientFolios)
          .AddMethod(__Method_IsMasterPaysCheck, serviceImpl.IsMasterPaysCheck)
          .AddMethod(__Method_RemoveMasterOrGroupGuaranteeFromClient, serviceImpl.RemoveMasterOrGroupGuaranteeFromClient).Build();
    }

  }
}
#endregion
