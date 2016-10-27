// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rpc/room_claims_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Operations.RPC {
  public static class RoomClaimsSvc
  {
    static readonly string __ServiceName = "holms.types.operations.rpc.RoomClaimsSvc";

    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest> __Marshaller_RoomClaimsSvcSearchRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchResponse> __Marshaller_RoomClaimsSvcSearchResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.ContinuousRoomClaimsSvcSearchResponse> __Marshaller_ContinuousRoomClaimsSvcSearchResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.ContinuousRoomClaimsSvcSearchResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationRequest> __Marshaller_RoomClaimsSvcGetClaimableByReservationRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationResponse> __Marshaller_RoomClaimsSvcGetClaimableByReservationResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsRequest> __Marshaller_RoomClaimsSvcUpdateReservationRoomClaimsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsResponse> __Marshaller_RoomClaimsSvcUpdateReservationRoomClaimsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsRequest> __Marshaller_GetAllRoomsWithClaimsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsResponse> __Marshaller_GetAllRoomsWithClaimsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsResponse.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest, global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchResponse> __Method_Search = new Method<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest, global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchResponse>(
        MethodType.Unary,
        __ServiceName,
        "Search",
        __Marshaller_RoomClaimsSvcSearchRequest,
        __Marshaller_RoomClaimsSvcSearchResponse);

    static readonly Method<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest, global::HOLMS.Types.Operations.RPC.ContinuousRoomClaimsSvcSearchResponse> __Method_SearchContinuousClaims = new Method<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest, global::HOLMS.Types.Operations.RPC.ContinuousRoomClaimsSvcSearchResponse>(
        MethodType.Unary,
        __ServiceName,
        "SearchContinuousClaims",
        __Marshaller_RoomClaimsSvcSearchRequest,
        __Marshaller_ContinuousRoomClaimsSvcSearchResponse);

    static readonly Method<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationRequest, global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationResponse> __Method_GetClaimableByReservation = new Method<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationRequest, global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetClaimableByReservation",
        __Marshaller_RoomClaimsSvcGetClaimableByReservationRequest,
        __Marshaller_RoomClaimsSvcGetClaimableByReservationResponse);

    static readonly Method<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsRequest, global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsResponse> __Method_UpdateReservationRoomClaims = new Method<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsRequest, global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsResponse>(
        MethodType.Unary,
        __ServiceName,
        "UpdateReservationRoomClaims",
        __Marshaller_RoomClaimsSvcUpdateReservationRoomClaimsRequest,
        __Marshaller_RoomClaimsSvcUpdateReservationRoomClaimsResponse);

    static readonly Method<global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsRequest, global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsResponse> __Method_GetAllRoomsWithClaims = new Method<global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsRequest, global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetAllRoomsWithClaims",
        __Marshaller_GetAllRoomsWithClaimsRequest,
        __Marshaller_GetAllRoomsWithClaimsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Operations.RPC.RoomClaimsSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RoomClaimsSvc</summary>
    public abstract class RoomClaimsSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchResponse> Search(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.ContinuousRoomClaimsSvcSearchResponse> SearchContinuousClaims(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationResponse> GetClaimableByReservation(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsResponse> UpdateReservationRoomClaims(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsResponse> GetAllRoomsWithClaims(global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RoomClaimsSvc</summary>
    public class RoomClaimsSvcClient : ClientBase<RoomClaimsSvcClient>
    {
      /// <summary>Creates a new client for RoomClaimsSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RoomClaimsSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RoomClaimsSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RoomClaimsSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RoomClaimsSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RoomClaimsSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchResponse Search(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Search(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchResponse Search(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Search, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchResponse> SearchAsync(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchResponse> SearchAsync(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Search, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.ContinuousRoomClaimsSvcSearchResponse SearchContinuousClaims(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchContinuousClaims(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.ContinuousRoomClaimsSvcSearchResponse SearchContinuousClaims(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchContinuousClaims, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.ContinuousRoomClaimsSvcSearchResponse> SearchContinuousClaimsAsync(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchContinuousClaimsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.ContinuousRoomClaimsSvcSearchResponse> SearchContinuousClaimsAsync(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcSearchRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchContinuousClaims, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationResponse GetClaimableByReservation(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetClaimableByReservation(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationResponse GetClaimableByReservation(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetClaimableByReservation, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationResponse> GetClaimableByReservationAsync(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetClaimableByReservationAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationResponse> GetClaimableByReservationAsync(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcGetClaimableByReservationRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetClaimableByReservation, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsResponse UpdateReservationRoomClaims(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateReservationRoomClaims(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsResponse UpdateReservationRoomClaims(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateReservationRoomClaims, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsResponse> UpdateReservationRoomClaimsAsync(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateReservationRoomClaimsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsResponse> UpdateReservationRoomClaimsAsync(global::HOLMS.Types.Operations.RPC.RoomClaimsSvcUpdateReservationRoomClaimsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateReservationRoomClaims, null, options, request);
      }
      public virtual global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsResponse GetAllRoomsWithClaims(global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAllRoomsWithClaims(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsResponse GetAllRoomsWithClaims(global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllRoomsWithClaims, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsResponse> GetAllRoomsWithClaimsAsync(global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAllRoomsWithClaimsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsResponse> GetAllRoomsWithClaimsAsync(global::HOLMS.Types.Operations.RPC.GetAllRoomsWithClaimsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllRoomsWithClaims, null, options, request);
      }
      protected override RoomClaimsSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RoomClaimsSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(RoomClaimsSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Search, serviceImpl.Search)
          .AddMethod(__Method_SearchContinuousClaims, serviceImpl.SearchContinuousClaims)
          .AddMethod(__Method_GetClaimableByReservation, serviceImpl.GetClaimableByReservation)
          .AddMethod(__Method_UpdateReservationRoomClaims, serviceImpl.UpdateReservationRoomClaims)
          .AddMethod(__Method_GetAllRoomsWithClaims, serviceImpl.GetAllRoomsWithClaims).Build();
    }

  }
}
#endregion
