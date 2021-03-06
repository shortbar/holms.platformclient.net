// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/turn_away_reason_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.Booking.RPC {
  public static partial class TurnAwayReasonSvc
  {
    static readonly string __ServiceName = "holms.types.booking.rpc.TurnAwayReasonSvc";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.RPC.TurnAwayReasonSvcAllResponse> __Marshaller_TurnAwayReasonSvcAllResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.TurnAwayReasonSvcAllResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicator> __Marshaller_TurnAwayReasonIndicator = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicator.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.TurnAwayReason> __Marshaller_TurnAwayReason = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.TurnAwayReason.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Primitive.ServerActionConfirmation> __Marshaller_ServerActionConfirmation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Primitive.ServerActionConfirmation.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Booking.RPC.TurnAwayReasonSvcAllResponse> __Method_All = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Booking.RPC.TurnAwayReasonSvcAllResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "All",
        __Marshaller_Empty,
        __Marshaller_TurnAwayReasonSvcAllResponse);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicator, global::HOLMS.Types.Booking.TurnAwayReason> __Method_GetById = new grpc::Method<global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicator, global::HOLMS.Types.Booking.TurnAwayReason>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetById",
        __Marshaller_TurnAwayReasonIndicator,
        __Marshaller_TurnAwayReason);

    static readonly grpc::Method<global::HOLMS.Types.Booking.TurnAwayReason, global::HOLMS.Types.Booking.TurnAwayReason> __Method_Create = new grpc::Method<global::HOLMS.Types.Booking.TurnAwayReason, global::HOLMS.Types.Booking.TurnAwayReason>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_TurnAwayReason,
        __Marshaller_TurnAwayReason);

    static readonly grpc::Method<global::HOLMS.Types.Booking.TurnAwayReason, global::HOLMS.Types.Booking.TurnAwayReason> __Method_Update = new grpc::Method<global::HOLMS.Types.Booking.TurnAwayReason, global::HOLMS.Types.Booking.TurnAwayReason>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_TurnAwayReason,
        __Marshaller_TurnAwayReason);

    static readonly grpc::Method<global::HOLMS.Types.Booking.TurnAwayReason, global::HOLMS.Types.Primitive.ServerActionConfirmation> __Method_Delete = new grpc::Method<global::HOLMS.Types.Booking.TurnAwayReason, global::HOLMS.Types.Primitive.ServerActionConfirmation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_TurnAwayReason,
        __Marshaller_ServerActionConfirmation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Booking.RPC.TurnAwayReasonSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TurnAwayReasonSvc</summary>
    public abstract partial class TurnAwayReasonSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.TurnAwayReasonSvcAllResponse> All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.TurnAwayReason> GetById(global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.TurnAwayReason> Create(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.TurnAwayReason> Update(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Primitive.ServerActionConfirmation> Delete(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TurnAwayReasonSvc</summary>
    public partial class TurnAwayReasonSvcClient : grpc::ClientBase<TurnAwayReasonSvcClient>
    {
      /// <summary>Creates a new client for TurnAwayReasonSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TurnAwayReasonSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TurnAwayReasonSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TurnAwayReasonSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TurnAwayReasonSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TurnAwayReasonSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Booking.RPC.TurnAwayReasonSvcAllResponse All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return All(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.TurnAwayReasonSvcAllResponse All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_All, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.TurnAwayReasonSvcAllResponse> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.TurnAwayReasonSvcAllResponse> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_All, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.TurnAwayReason GetById(global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.TurnAwayReason GetById(global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.TurnAwayReason> GetByIdAsync(global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.TurnAwayReason> GetByIdAsync(global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetById, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.TurnAwayReason Create(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.TurnAwayReason Create(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.TurnAwayReason> CreateAsync(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.TurnAwayReason> CreateAsync(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.TurnAwayReason Update(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.TurnAwayReason Update(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.TurnAwayReason> UpdateAsync(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.TurnAwayReason> UpdateAsync(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      public virtual global::HOLMS.Types.Primitive.ServerActionConfirmation Delete(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Primitive.ServerActionConfirmation Delete(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Primitive.ServerActionConfirmation> DeleteAsync(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Primitive.ServerActionConfirmation> DeleteAsync(global::HOLMS.Types.Booking.TurnAwayReason request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TurnAwayReasonSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TurnAwayReasonSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TurnAwayReasonSvcBase serviceImpl)
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
