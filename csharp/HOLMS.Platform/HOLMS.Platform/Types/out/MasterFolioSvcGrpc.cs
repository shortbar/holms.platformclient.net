// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/rpc/master_folio_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Money.RPC {
  public static class MasterFolioSvc
  {
    static readonly string __ServiceName = "holms.types.money.rpc.MasterFolioSvc";

    static readonly Marshaller<global::HOLMS.Types.Money.RPC.MasterFolioServiceMasterFolioRequest> __Marshaller_MasterFolioServiceMasterFolioRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.MasterFolioServiceMasterFolioRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.MasterFolioServiceRequestMasterFolioResponse> __Marshaller_MasterFolioServiceRequestMasterFolioResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.MasterFolioServiceRequestMasterFolioResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.MasterFolioSvcRemoveMasterFolioRequest> __Marshaller_MasterFolioSvcRemoveMasterFolioRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.MasterFolioSvcRemoveMasterFolioRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.MasterFolioServiceRemoveMasterFolioResponse> __Marshaller_MasterFolioServiceRemoveMasterFolioResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.MasterFolioServiceRemoveMasterFolioResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.Folio.PostedChargeCredit> __Marshaller_PostedChargeCredit = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Folio.PostedChargeCredit.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.MasterFolioSvcFolioSwapResponse> __Marshaller_MasterFolioSvcFolioSwapResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.MasterFolioSvcFolioSwapResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.MasterFolioSvcGetMasterFolioAssignmentsRequest> __Marshaller_MasterFolioSvcGetMasterFolioAssignmentsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.MasterFolioSvcGetMasterFolioAssignmentsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.MasterFolioSvcReservationMasterFolioAssignmentList> __Marshaller_MasterFolioSvcReservationMasterFolioAssignmentList = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.MasterFolioSvcReservationMasterFolioAssignmentList.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.Money.RPC.MasterFolioServiceMasterFolioRequest, global::HOLMS.Types.Money.RPC.MasterFolioServiceRequestMasterFolioResponse> __Method_RequestMasterFolio = new Method<global::HOLMS.Types.Money.RPC.MasterFolioServiceMasterFolioRequest, global::HOLMS.Types.Money.RPC.MasterFolioServiceRequestMasterFolioResponse>(
        MethodType.Unary,
        __ServiceName,
        "RequestMasterFolio",
        __Marshaller_MasterFolioServiceMasterFolioRequest,
        __Marshaller_MasterFolioServiceRequestMasterFolioResponse);

    static readonly Method<global::HOLMS.Types.Money.RPC.MasterFolioSvcRemoveMasterFolioRequest, global::HOLMS.Types.Money.RPC.MasterFolioServiceRemoveMasterFolioResponse> __Method_RemoveMasterFolio = new Method<global::HOLMS.Types.Money.RPC.MasterFolioSvcRemoveMasterFolioRequest, global::HOLMS.Types.Money.RPC.MasterFolioServiceRemoveMasterFolioResponse>(
        MethodType.Unary,
        __ServiceName,
        "RemoveMasterFolio",
        __Marshaller_MasterFolioSvcRemoveMasterFolioRequest,
        __Marshaller_MasterFolioServiceRemoveMasterFolioResponse);

    static readonly Method<global::HOLMS.Types.Money.Folio.PostedChargeCredit, global::HOLMS.Types.Money.RPC.MasterFolioSvcFolioSwapResponse> __Method_FolioSwap = new Method<global::HOLMS.Types.Money.Folio.PostedChargeCredit, global::HOLMS.Types.Money.RPC.MasterFolioSvcFolioSwapResponse>(
        MethodType.Unary,
        __ServiceName,
        "FolioSwap",
        __Marshaller_PostedChargeCredit,
        __Marshaller_MasterFolioSvcFolioSwapResponse);

    static readonly Method<global::HOLMS.Types.Money.RPC.MasterFolioSvcGetMasterFolioAssignmentsRequest, global::HOLMS.Types.Money.RPC.MasterFolioSvcReservationMasterFolioAssignmentList> __Method_GetMasterFolioAssignments = new Method<global::HOLMS.Types.Money.RPC.MasterFolioSvcGetMasterFolioAssignmentsRequest, global::HOLMS.Types.Money.RPC.MasterFolioSvcReservationMasterFolioAssignmentList>(
        MethodType.Unary,
        __ServiceName,
        "GetMasterFolioAssignments",
        __Marshaller_MasterFolioSvcGetMasterFolioAssignmentsRequest,
        __Marshaller_MasterFolioSvcReservationMasterFolioAssignmentList);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Money.RPC.MasterFolioSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MasterFolioSvc</summary>
    public abstract class MasterFolioSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.MasterFolioServiceRequestMasterFolioResponse> RequestMasterFolio(global::HOLMS.Types.Money.RPC.MasterFolioServiceMasterFolioRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.MasterFolioServiceRemoveMasterFolioResponse> RemoveMasterFolio(global::HOLMS.Types.Money.RPC.MasterFolioSvcRemoveMasterFolioRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.MasterFolioSvcFolioSwapResponse> FolioSwap(global::HOLMS.Types.Money.Folio.PostedChargeCredit request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.MasterFolioSvcReservationMasterFolioAssignmentList> GetMasterFolioAssignments(global::HOLMS.Types.Money.RPC.MasterFolioSvcGetMasterFolioAssignmentsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MasterFolioSvc</summary>
    public class MasterFolioSvcClient : ClientBase<MasterFolioSvcClient>
    {
      /// <summary>Creates a new client for MasterFolioSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MasterFolioSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MasterFolioSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MasterFolioSvcClient(CallInvoker callInvoker) : base(callInvoker)
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

      public virtual global::HOLMS.Types.Money.RPC.MasterFolioServiceRequestMasterFolioResponse RequestMasterFolio(global::HOLMS.Types.Money.RPC.MasterFolioServiceMasterFolioRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestMasterFolio(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.MasterFolioServiceRequestMasterFolioResponse RequestMasterFolio(global::HOLMS.Types.Money.RPC.MasterFolioServiceMasterFolioRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestMasterFolio, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MasterFolioServiceRequestMasterFolioResponse> RequestMasterFolioAsync(global::HOLMS.Types.Money.RPC.MasterFolioServiceMasterFolioRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RequestMasterFolioAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MasterFolioServiceRequestMasterFolioResponse> RequestMasterFolioAsync(global::HOLMS.Types.Money.RPC.MasterFolioServiceMasterFolioRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestMasterFolio, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.RPC.MasterFolioServiceRemoveMasterFolioResponse RemoveMasterFolio(global::HOLMS.Types.Money.RPC.MasterFolioSvcRemoveMasterFolioRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveMasterFolio(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.MasterFolioServiceRemoveMasterFolioResponse RemoveMasterFolio(global::HOLMS.Types.Money.RPC.MasterFolioSvcRemoveMasterFolioRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoveMasterFolio, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MasterFolioServiceRemoveMasterFolioResponse> RemoveMasterFolioAsync(global::HOLMS.Types.Money.RPC.MasterFolioSvcRemoveMasterFolioRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveMasterFolioAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MasterFolioServiceRemoveMasterFolioResponse> RemoveMasterFolioAsync(global::HOLMS.Types.Money.RPC.MasterFolioSvcRemoveMasterFolioRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoveMasterFolio, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.RPC.MasterFolioSvcFolioSwapResponse FolioSwap(global::HOLMS.Types.Money.Folio.PostedChargeCredit request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return FolioSwap(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.MasterFolioSvcFolioSwapResponse FolioSwap(global::HOLMS.Types.Money.Folio.PostedChargeCredit request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FolioSwap, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MasterFolioSvcFolioSwapResponse> FolioSwapAsync(global::HOLMS.Types.Money.Folio.PostedChargeCredit request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return FolioSwapAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MasterFolioSvcFolioSwapResponse> FolioSwapAsync(global::HOLMS.Types.Money.Folio.PostedChargeCredit request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FolioSwap, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.RPC.MasterFolioSvcReservationMasterFolioAssignmentList GetMasterFolioAssignments(global::HOLMS.Types.Money.RPC.MasterFolioSvcGetMasterFolioAssignmentsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetMasterFolioAssignments(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.MasterFolioSvcReservationMasterFolioAssignmentList GetMasterFolioAssignments(global::HOLMS.Types.Money.RPC.MasterFolioSvcGetMasterFolioAssignmentsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetMasterFolioAssignments, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MasterFolioSvcReservationMasterFolioAssignmentList> GetMasterFolioAssignmentsAsync(global::HOLMS.Types.Money.RPC.MasterFolioSvcGetMasterFolioAssignmentsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetMasterFolioAssignmentsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MasterFolioSvcReservationMasterFolioAssignmentList> GetMasterFolioAssignmentsAsync(global::HOLMS.Types.Money.RPC.MasterFolioSvcGetMasterFolioAssignmentsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetMasterFolioAssignments, null, options, request);
      }
      protected override MasterFolioSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MasterFolioSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(MasterFolioSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RequestMasterFolio, serviceImpl.RequestMasterFolio)
          .AddMethod(__Method_RemoveMasterFolio, serviceImpl.RemoveMasterFolio)
          .AddMethod(__Method_FolioSwap, serviceImpl.FolioSwap)
          .AddMethod(__Method_GetMasterFolioAssignments, serviceImpl.GetMasterFolioAssignments).Build();
    }

  }
}
#endregion
