// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rpc/out_of_order_record_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.Operations.RPC {
  public static partial class OutOfOrderRecordSvc
  {
    static readonly string __ServiceName = "holms.types.operations.rpc.OutOfOrderRecordSvc";

    static readonly grpc::Marshaller<global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator> __Marshaller_PropertyIndicator = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse> __Marshaller_OutOfOrderRecordSvcAllResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator> __Marshaller_OutOfOrderRecordIndicator = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse> __Marshaller_OutOfOrderRecordGetByIdResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcCreateRequest> __Marshaller_OutOfOrderRecordSvcCreateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcCreateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse> __Marshaller_OutOfOrderRecordCreateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcUpdateRequest> __Marshaller_OutOfOrderRecordSvcUpdateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcUpdateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse> __Marshaller_OutOfOrderRecordUpdateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse> __Marshaller_OutOfOrderRecordDeleteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse> __Method_All = new grpc::Method<global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "All",
        __Marshaller_PropertyIndicator,
        __Marshaller_OutOfOrderRecordSvcAllResponse);

    static readonly grpc::Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse> __Method_GetById = new grpc::Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetById",
        __Marshaller_OutOfOrderRecordIndicator,
        __Marshaller_OutOfOrderRecordGetByIdResponse);

    static readonly grpc::Method<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcCreateRequest, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse> __Method_Create = new grpc::Method<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcCreateRequest, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_OutOfOrderRecordSvcCreateRequest,
        __Marshaller_OutOfOrderRecordCreateResponse);

    static readonly grpc::Method<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcUpdateRequest, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse> __Method_Update = new grpc::Method<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcUpdateRequest, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_OutOfOrderRecordSvcUpdateRequest,
        __Marshaller_OutOfOrderRecordUpdateResponse);

    static readonly grpc::Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse> __Method_Delete = new grpc::Method<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator, global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse>(
        grpc::MethodType.Unary,
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
    public abstract partial class OutOfOrderRecordSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse> All(global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse> GetById(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse> Create(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcCreateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse> Update(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcUpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse> Delete(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for OutOfOrderRecordSvc</summary>
    public partial class OutOfOrderRecordSvcClient : grpc::ClientBase<OutOfOrderRecordSvcClient>
    {
      /// <summary>Creates a new client for OutOfOrderRecordSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OutOfOrderRecordSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OutOfOrderRecordSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OutOfOrderRecordSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
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

      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse All(global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return All(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse All(global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_All, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse> AllAsync(global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse> AllAsync(global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_All, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse GetById(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse GetById(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse> GetByIdAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse> GetByIdAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetById, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse Create(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcCreateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse Create(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcCreateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse> CreateAsync(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcCreateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse> CreateAsync(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcCreateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse Update(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse Update(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse> UpdateAsync(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse> UpdateAsync(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse Delete(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse Delete(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse> DeleteAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse> DeleteAsync(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OutOfOrderRecordSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OutOfOrderRecordSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(OutOfOrderRecordSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_All, serviceImpl.All)
          .AddMethod(__Method_GetById, serviceImpl.GetById)
          .AddMethod(__Method_Create, serviceImpl.Create)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete).Build();
    }

  }
}
#endregion
