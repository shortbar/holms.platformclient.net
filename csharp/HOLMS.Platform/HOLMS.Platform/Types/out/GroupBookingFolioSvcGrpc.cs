// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/rpc/group_booking_folio_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Money.RPC {
  public static class GroupBookingFolioSvc
  {
    static readonly string __ServiceName = "holms.types.money.rpc.GroupBookingFolioSvc";

    static readonly Marshaller<global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator> __Marshaller_GroupBookingIndicator = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcGetFolioStateResponse> __Marshaller_GroupBookingFolioSvcGetFolioStateResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcGetFolioStateResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromTokenRequest> __Marshaller_GroupBookingFolioSvcCardAuthorizationFromTokenRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromTokenRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> __Marshaller_CardAuthorizationResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Cards.CardAuthorizationResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromPresentCardRequest> __Marshaller_GroupBookingFolioSvcCardAuthorizationFromPresentCardRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromPresentCardRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromNotPresentCardRequest> __Marshaller_GroupBookingFolioSvcCardAuthorizationFromNotPresentCardRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromNotPresentCardRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentRequest> __Marshaller_GroupBookingFolioSvcPostCardPaymentRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentResponse> __Marshaller_GroupBookingFolioSvcPostCardPaymentResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentRequest> __Marshaller_GroupBookingFolioSvcPostCheckPaymentRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentResponse> __Marshaller_GroupBookingFolioSvcPostCheckPaymentResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentRequest> __Marshaller_GroupBookingFolioSvcPostCashPaymentRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentResponse> __Marshaller_GroupBookingFolioSvcPostCashPaymentResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentResponse.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator, global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcGetFolioStateResponse> __Method_GetFolioState = new Method<global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator, global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcGetFolioStateResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetFolioState",
        __Marshaller_GroupBookingIndicator,
        __Marshaller_GroupBookingFolioSvcGetFolioStateResponse);

    static readonly Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromTokenRequest, global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> __Method_AddCardAuthorizationFromToken = new Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromTokenRequest, global::HOLMS.Types.Money.Cards.CardAuthorizationResponse>(
        MethodType.Unary,
        __ServiceName,
        "AddCardAuthorizationFromToken",
        __Marshaller_GroupBookingFolioSvcCardAuthorizationFromTokenRequest,
        __Marshaller_CardAuthorizationResponse);

    static readonly Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromPresentCardRequest, global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> __Method_AddCardAuthorizationFromPresentedCard = new Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromPresentCardRequest, global::HOLMS.Types.Money.Cards.CardAuthorizationResponse>(
        MethodType.Unary,
        __ServiceName,
        "AddCardAuthorizationFromPresentedCard",
        __Marshaller_GroupBookingFolioSvcCardAuthorizationFromPresentCardRequest,
        __Marshaller_CardAuthorizationResponse);

    static readonly Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromNotPresentCardRequest, global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> __Method_AddCardAuthorizationFromNotPresentCard = new Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromNotPresentCardRequest, global::HOLMS.Types.Money.Cards.CardAuthorizationResponse>(
        MethodType.Unary,
        __ServiceName,
        "AddCardAuthorizationFromNotPresentCard",
        __Marshaller_GroupBookingFolioSvcCardAuthorizationFromNotPresentCardRequest,
        __Marshaller_CardAuthorizationResponse);

    static readonly Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentRequest, global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentResponse> __Method_PostCardPayment = new Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentRequest, global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentResponse>(
        MethodType.Unary,
        __ServiceName,
        "PostCardPayment",
        __Marshaller_GroupBookingFolioSvcPostCardPaymentRequest,
        __Marshaller_GroupBookingFolioSvcPostCardPaymentResponse);

    static readonly Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentRequest, global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentResponse> __Method_PostCheckPayment = new Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentRequest, global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentResponse>(
        MethodType.Unary,
        __ServiceName,
        "PostCheckPayment",
        __Marshaller_GroupBookingFolioSvcPostCheckPaymentRequest,
        __Marshaller_GroupBookingFolioSvcPostCheckPaymentResponse);

    static readonly Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentRequest, global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentResponse> __Method_PostCashPayment = new Method<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentRequest, global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentResponse>(
        MethodType.Unary,
        __ServiceName,
        "PostCashPayment",
        __Marshaller_GroupBookingFolioSvcPostCashPaymentRequest,
        __Marshaller_GroupBookingFolioSvcPostCashPaymentResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GroupBookingFolioSvc</summary>
    public abstract class GroupBookingFolioSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcGetFolioStateResponse> GetFolioState(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Cards
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> AddCardAuthorizationFromToken(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromTokenRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> AddCardAuthorizationFromPresentedCard(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromPresentCardRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> AddCardAuthorizationFromNotPresentCard(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromNotPresentCardRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Payments
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentResponse> PostCardPayment(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentResponse> PostCheckPayment(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentResponse> PostCashPayment(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GroupBookingFolioSvc</summary>
    public class GroupBookingFolioSvcClient : ClientBase<GroupBookingFolioSvcClient>
    {
      /// <summary>Creates a new client for GroupBookingFolioSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GroupBookingFolioSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GroupBookingFolioSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GroupBookingFolioSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GroupBookingFolioSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GroupBookingFolioSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcGetFolioStateResponse GetFolioState(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioState(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcGetFolioStateResponse GetFolioState(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFolioState, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcGetFolioStateResponse> GetFolioStateAsync(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioStateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcGetFolioStateResponse> GetFolioStateAsync(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFolioState, null, options, request);
      }
      /// <summary>
      ///  Cards
      /// </summary>
      public virtual global::HOLMS.Types.Money.Cards.CardAuthorizationResponse AddCardAuthorizationFromToken(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddCardAuthorizationFromToken(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Cards
      /// </summary>
      public virtual global::HOLMS.Types.Money.Cards.CardAuthorizationResponse AddCardAuthorizationFromToken(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromTokenRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddCardAuthorizationFromToken, null, options, request);
      }
      /// <summary>
      ///  Cards
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> AddCardAuthorizationFromTokenAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddCardAuthorizationFromTokenAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Cards
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> AddCardAuthorizationFromTokenAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromTokenRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddCardAuthorizationFromToken, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.Cards.CardAuthorizationResponse AddCardAuthorizationFromPresentedCard(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromPresentCardRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddCardAuthorizationFromPresentedCard(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.Cards.CardAuthorizationResponse AddCardAuthorizationFromPresentedCard(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromPresentCardRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddCardAuthorizationFromPresentedCard, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> AddCardAuthorizationFromPresentedCardAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromPresentCardRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddCardAuthorizationFromPresentedCardAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> AddCardAuthorizationFromPresentedCardAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromPresentCardRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddCardAuthorizationFromPresentedCard, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.Cards.CardAuthorizationResponse AddCardAuthorizationFromNotPresentCard(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromNotPresentCardRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddCardAuthorizationFromNotPresentCard(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.Cards.CardAuthorizationResponse AddCardAuthorizationFromNotPresentCard(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromNotPresentCardRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddCardAuthorizationFromNotPresentCard, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> AddCardAuthorizationFromNotPresentCardAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromNotPresentCardRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddCardAuthorizationFromNotPresentCardAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.Cards.CardAuthorizationResponse> AddCardAuthorizationFromNotPresentCardAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcCardAuthorizationFromNotPresentCardRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddCardAuthorizationFromNotPresentCard, null, options, request);
      }
      /// <summary>
      ///  Payments
      /// </summary>
      public virtual global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentResponse PostCardPayment(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PostCardPayment(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Payments
      /// </summary>
      public virtual global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentResponse PostCardPayment(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PostCardPayment, null, options, request);
      }
      /// <summary>
      ///  Payments
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentResponse> PostCardPaymentAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PostCardPaymentAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Payments
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentResponse> PostCardPaymentAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCardPaymentRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PostCardPayment, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentResponse PostCheckPayment(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PostCheckPayment(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentResponse PostCheckPayment(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PostCheckPayment, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentResponse> PostCheckPaymentAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PostCheckPaymentAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentResponse> PostCheckPaymentAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCheckPaymentRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PostCheckPayment, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentResponse PostCashPayment(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PostCashPayment(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentResponse PostCashPayment(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PostCashPayment, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentResponse> PostCashPaymentAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PostCashPaymentAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentResponse> PostCashPaymentAsync(global::HOLMS.Types.Money.RPC.GroupBookingFolioSvcPostCashPaymentRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PostCashPayment, null, options, request);
      }
      protected override GroupBookingFolioSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GroupBookingFolioSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(GroupBookingFolioSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFolioState, serviceImpl.GetFolioState)
          .AddMethod(__Method_AddCardAuthorizationFromToken, serviceImpl.AddCardAuthorizationFromToken)
          .AddMethod(__Method_AddCardAuthorizationFromPresentedCard, serviceImpl.AddCardAuthorizationFromPresentedCard)
          .AddMethod(__Method_AddCardAuthorizationFromNotPresentCard, serviceImpl.AddCardAuthorizationFromNotPresentCard)
          .AddMethod(__Method_PostCardPayment, serviceImpl.PostCardPayment)
          .AddMethod(__Method_PostCheckPayment, serviceImpl.PostCheckPayment)
          .AddMethod(__Method_PostCashPayment, serviceImpl.PostCashPayment).Build();
    }

  }
}
#endregion