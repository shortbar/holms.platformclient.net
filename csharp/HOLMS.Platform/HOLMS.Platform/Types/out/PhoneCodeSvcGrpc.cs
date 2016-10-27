// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/rpc/phone_code_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.TenancyConfig.RPC {
  public static class PhoneCodeSvc
  {
    static readonly string __ServiceName = "holms.types.tenancy_config.rpc.PhoneCodeSvc";

    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.RPC.PhoneCodes> __Marshaller_PhoneCodes = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.RPC.PhoneCodes.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.PhoneCode> __Marshaller_PhoneCode = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.PhoneCode.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Primitive.ServerActionConfirmation> __Marshaller_ServerActionConfirmation = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Primitive.ServerActionConfirmation.Parser.ParseFrom);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.RPC.PhoneCodes> __Method_All = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.RPC.PhoneCodes>(
        MethodType.Unary,
        __ServiceName,
        "All",
        __Marshaller_Empty,
        __Marshaller_PhoneCodes);

    static readonly Method<global::HOLMS.Types.TenancyConfig.PhoneCode, global::HOLMS.Types.TenancyConfig.PhoneCode> __Method_Update = new Method<global::HOLMS.Types.TenancyConfig.PhoneCode, global::HOLMS.Types.TenancyConfig.PhoneCode>(
        MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_PhoneCode,
        __Marshaller_PhoneCode);

    static readonly Method<global::HOLMS.Types.TenancyConfig.PhoneCode, global::HOLMS.Types.Primitive.ServerActionConfirmation> __Method_Delete = new Method<global::HOLMS.Types.TenancyConfig.PhoneCode, global::HOLMS.Types.Primitive.ServerActionConfirmation>(
        MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_PhoneCode,
        __Marshaller_ServerActionConfirmation);

    static readonly Method<global::HOLMS.Types.TenancyConfig.PhoneCode, global::HOLMS.Types.TenancyConfig.PhoneCode> __Method_Create = new Method<global::HOLMS.Types.TenancyConfig.PhoneCode, global::HOLMS.Types.TenancyConfig.PhoneCode>(
        MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_PhoneCode,
        __Marshaller_PhoneCode);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.TenancyConfig.RPC.PhoneCodeSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PhoneCodeSvc</summary>
    public abstract class PhoneCodeSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.RPC.PhoneCodes> All(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.PhoneCode> Update(global::HOLMS.Types.TenancyConfig.PhoneCode request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Primitive.ServerActionConfirmation> Delete(global::HOLMS.Types.TenancyConfig.PhoneCode request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.PhoneCode> Create(global::HOLMS.Types.TenancyConfig.PhoneCode request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PhoneCodeSvc</summary>
    public class PhoneCodeSvcClient : ClientBase<PhoneCodeSvcClient>
    {
      /// <summary>Creates a new client for PhoneCodeSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PhoneCodeSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PhoneCodeSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PhoneCodeSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PhoneCodeSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PhoneCodeSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.TenancyConfig.RPC.PhoneCodes All(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return All(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.RPC.PhoneCodes All(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_All, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.RPC.PhoneCodes> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.RPC.PhoneCodes> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_All, null, options, request);
      }
      public virtual global::HOLMS.Types.TenancyConfig.PhoneCode Update(global::HOLMS.Types.TenancyConfig.PhoneCode request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Update(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.PhoneCode Update(global::HOLMS.Types.TenancyConfig.PhoneCode request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.PhoneCode> UpdateAsync(global::HOLMS.Types.TenancyConfig.PhoneCode request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.PhoneCode> UpdateAsync(global::HOLMS.Types.TenancyConfig.PhoneCode request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      public virtual global::HOLMS.Types.Primitive.ServerActionConfirmation Delete(global::HOLMS.Types.TenancyConfig.PhoneCode request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Delete(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Primitive.ServerActionConfirmation Delete(global::HOLMS.Types.TenancyConfig.PhoneCode request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Primitive.ServerActionConfirmation> DeleteAsync(global::HOLMS.Types.TenancyConfig.PhoneCode request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Primitive.ServerActionConfirmation> DeleteAsync(global::HOLMS.Types.TenancyConfig.PhoneCode request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      public virtual global::HOLMS.Types.TenancyConfig.PhoneCode Create(global::HOLMS.Types.TenancyConfig.PhoneCode request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Create(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.PhoneCode Create(global::HOLMS.Types.TenancyConfig.PhoneCode request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.PhoneCode> CreateAsync(global::HOLMS.Types.TenancyConfig.PhoneCode request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.PhoneCode> CreateAsync(global::HOLMS.Types.TenancyConfig.PhoneCode request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      protected override PhoneCodeSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PhoneCodeSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(PhoneCodeSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_All, serviceImpl.All)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete)
          .AddMethod(__Method_Create, serviceImpl.Create).Build();
    }

  }
}
#endregion
