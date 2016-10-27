// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rpc/out_of_order_record_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Operations.RPC {
  public static class OutOfOrderRecordSvc
  {
    static readonly string __ServiceName = "holms.types.operations.rpc.OutOfOrderRecordSvc";

    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator> __Marshaller_PropertyIndicator = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse> __Marshaller_OutOfOrderRecordSvcAllResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator> __Marshaller_OutOfOrderRecordIndicator = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse> __Marshaller_OutOfOrderRecordGetByIdResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord> __Marshaller_OutOfOrderRecord = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse> __Marshaller_OutOfOrderRecordCreateResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse> __Marshaller_OutOfOrderRecordUpdateResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse> __Marshaller_OutOfOrderRecordDeleteResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse> __Method_All = new Method<global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse>(
        MethodType.Unary,
        __ServiceName,
        "All",
        __Marshaller_PropertyIndicator,
        __Marshaller_OutOfOrderRecordSvcAllResponse);

    static readonly Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse> __Method_GetById = new Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetById",
        __Marshaller_OutOfOrderRecordIndicator,
        __Marshaller_OutOfOrderRecordGetByIdResponse);

    static readonly Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse> __Method_Create = new Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse>(
        MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_OutOfOrderRecord,
        __Marshaller_OutOfOrderRecordCreateResponse);

    static readonly Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse> __Method_Update = new Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse>(
        MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_OutOfOrderRecord,
        __Marshaller_OutOfOrderRecordUpdateResponse);

    static readonly Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse> __Method_Delete = new Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse>(
        MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_OutOfOrderRecordIndicator,
        __Marshaller_OutOfOrderRecordDeleteResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of OutOfOrderRecordSvc</summary>
    public abstract class OutOfOrderRecordSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse> All(global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse> GetById(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse> Create(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse> Update(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse> Delete(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for OutOfOrderRecordSvc</summary>
    public class OutOfOrderRecordSvcClient : ClientBase<OutOfOrderRecordSvcClient>
    {
      /// <summary>Creates a new client for OutOfOrderRecordSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OutOfOrderRecordSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OutOfOrderRecordSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OutOfOrderRecordSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OutOfOrderRecordSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OutOfOrderRecordSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse All(global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return All(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse All(global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_All, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse> AllAsync(global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse> AllAsync(global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_All, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse GetById(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetById(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse GetById(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetById, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse> GetByIdAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetByIdAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse> GetByIdAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetById, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse Create(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Create(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse Create(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse> CreateAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse> CreateAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse Update(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Update(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse Update(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse> UpdateAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse> UpdateAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse Delete(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Delete(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse Delete(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse> DeleteAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse> DeleteAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      protected override OutOfOrderRecordSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OutOfOrderRecordSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(OutOfOrderRecordSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_All, serviceImpl.All)
          .AddMethod(__Method_GetById, serviceImpl.GetById)
          .AddMethod(__Method_Create, serviceImpl.Create)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete).Build();
    }

  }
}
#endregion
