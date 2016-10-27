// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/rpc/card_processing_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Money.RPC {
  public static class CardProcessingSvc
  {
    static readonly string __ServiceName = "holms.types.money.rpc.CardProcessingSvc";

    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.CardProcessingSvcCaptureEnumResponse> __Marshaller_CardProcessingSvcCaptureEnumResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.CardProcessingSvcCaptureEnumResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange> __Marshaller_PbInclusiveCalendarDateRange = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> __Marshaller_MerchantBatchEnumResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.Cards.CardMerchantIndicator> __Marshaller_CardMerchantIndicator = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Cards.CardMerchantIndicator.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.Cards.MerchantBatch> __Marshaller_MerchantBatch = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Cards.MerchantBatch.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.Cards.MerchantCaptureIndicator> __Marshaller_MerchantCaptureIndicator = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Cards.MerchantCaptureIndicator.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResponse> __Marshaller_CardProcessingSvcCancelPendingCaptureResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.Cards.PaymentCardVerificationRequest> __Marshaller_PaymentCardVerificationRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Cards.PaymentCardVerificationRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> __Marshaller_CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse.Parser.ParseFrom);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Money.RPC.CardProcessingSvcCaptureEnumResponse> __Method_GetAllPendingCaptures = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Money.RPC.CardProcessingSvcCaptureEnumResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetAllPendingCaptures",
        __Marshaller_Empty,
        __Marshaller_CardProcessingSvcCaptureEnumResponse);

    static readonly Method<global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange, global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> __Method_GetAllBatches = new Method<global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange, global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetAllBatches",
        __Marshaller_PbInclusiveCalendarDateRange,
        __Marshaller_MerchantBatchEnumResponse);

    static readonly Method<global::HOLMS.Types.Money.Cards.CardMerchantIndicator, global::HOLMS.Types.Money.Cards.MerchantBatch> __Method_OpenAndSettleBatchFromPendingCapturesSpecificMerchant = new Method<global::HOLMS.Types.Money.Cards.CardMerchantIndicator, global::HOLMS.Types.Money.Cards.MerchantBatch>(
        MethodType.Unary,
        __ServiceName,
        "OpenAndSettleBatchFromPendingCapturesSpecificMerchant",
        __Marshaller_CardMerchantIndicator,
        __Marshaller_MerchantBatch);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> __Method_OpenAndSettleBatchFromPendingCapturesAllMerchants = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse>(
        MethodType.Unary,
        __ServiceName,
        "OpenAndSettleBatchFromPendingCapturesAllMerchants",
        __Marshaller_Empty,
        __Marshaller_MerchantBatchEnumResponse);

    static readonly Method<global::HOLMS.Types.Money.Cards.MerchantCaptureIndicator, global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResponse> __Method_CancelPendingCapture = new Method<global::HOLMS.Types.Money.Cards.MerchantCaptureIndicator, global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResponse>(
        MethodType.Unary,
        __ServiceName,
        "CancelPendingCapture",
        __Marshaller_MerchantCaptureIndicator,
        __Marshaller_CardProcessingSvcCancelPendingCaptureResponse);

    static readonly Method<global::HOLMS.Types.Money.Cards.PaymentCardVerificationRequest, global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> __Method_VerifyAndTokenizeNotPresentCard = new Method<global::HOLMS.Types.Money.Cards.PaymentCardVerificationRequest, global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse>(
        MethodType.Unary,
        __ServiceName,
        "VerifyAndTokenizeNotPresentCard",
        __Marshaller_PaymentCardVerificationRequest,
        __Marshaller_CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CardProcessingSvc</summary>
    public abstract class CardProcessingSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.CardProcessingSvcCaptureEnumResponse> GetAllPendingCaptures(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> GetAllBatches(global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.Cards.MerchantBatch> OpenAndSettleBatchFromPendingCapturesSpecificMerchant(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> OpenAndSettleBatchFromPendingCapturesAllMerchants(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResponse> CancelPendingCapture(global::HOLMS.Types.Money.Cards.MerchantCaptureIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> VerifyAndTokenizeNotPresentCard(global::HOLMS.Types.Money.Cards.PaymentCardVerificationRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CardProcessingSvc</summary>
    public class CardProcessingSvcClient : ClientBase<CardProcessingSvcClient>
    {
      /// <summary>Creates a new client for CardProcessingSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CardProcessingSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CardProcessingSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CardProcessingSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CardProcessingSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CardProcessingSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcCaptureEnumResponse GetAllPendingCaptures(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAllPendingCaptures(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcCaptureEnumResponse GetAllPendingCaptures(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllPendingCaptures, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcCaptureEnumResponse> GetAllPendingCapturesAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAllPendingCapturesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcCaptureEnumResponse> GetAllPendingCapturesAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllPendingCaptures, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse GetAllBatches(global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAllBatches(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse GetAllBatches(global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllBatches, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> GetAllBatchesAsync(global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAllBatchesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> GetAllBatchesAsync(global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllBatches, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.Cards.MerchantBatch OpenAndSettleBatchFromPendingCapturesSpecificMerchant(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return OpenAndSettleBatchFromPendingCapturesSpecificMerchant(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.Cards.MerchantBatch OpenAndSettleBatchFromPendingCapturesSpecificMerchant(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OpenAndSettleBatchFromPendingCapturesSpecificMerchant, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.Cards.MerchantBatch> OpenAndSettleBatchFromPendingCapturesSpecificMerchantAsync(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return OpenAndSettleBatchFromPendingCapturesSpecificMerchantAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.Cards.MerchantBatch> OpenAndSettleBatchFromPendingCapturesSpecificMerchantAsync(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OpenAndSettleBatchFromPendingCapturesSpecificMerchant, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse OpenAndSettleBatchFromPendingCapturesAllMerchants(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return OpenAndSettleBatchFromPendingCapturesAllMerchants(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse OpenAndSettleBatchFromPendingCapturesAllMerchants(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OpenAndSettleBatchFromPendingCapturesAllMerchants, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> OpenAndSettleBatchFromPendingCapturesAllMerchantsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return OpenAndSettleBatchFromPendingCapturesAllMerchantsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> OpenAndSettleBatchFromPendingCapturesAllMerchantsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OpenAndSettleBatchFromPendingCapturesAllMerchants, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResponse CancelPendingCapture(global::HOLMS.Types.Money.Cards.MerchantCaptureIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CancelPendingCapture(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResponse CancelPendingCapture(global::HOLMS.Types.Money.Cards.MerchantCaptureIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CancelPendingCapture, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResponse> CancelPendingCaptureAsync(global::HOLMS.Types.Money.Cards.MerchantCaptureIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CancelPendingCaptureAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResponse> CancelPendingCaptureAsync(global::HOLMS.Types.Money.Cards.MerchantCaptureIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CancelPendingCapture, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse VerifyAndTokenizeNotPresentCard(global::HOLMS.Types.Money.Cards.PaymentCardVerificationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return VerifyAndTokenizeNotPresentCard(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse VerifyAndTokenizeNotPresentCard(global::HOLMS.Types.Money.Cards.PaymentCardVerificationRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_VerifyAndTokenizeNotPresentCard, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> VerifyAndTokenizeNotPresentCardAsync(global::HOLMS.Types.Money.Cards.PaymentCardVerificationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return VerifyAndTokenizeNotPresentCardAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> VerifyAndTokenizeNotPresentCardAsync(global::HOLMS.Types.Money.Cards.PaymentCardVerificationRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_VerifyAndTokenizeNotPresentCard, null, options, request);
      }
      protected override CardProcessingSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CardProcessingSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(CardProcessingSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllPendingCaptures, serviceImpl.GetAllPendingCaptures)
          .AddMethod(__Method_GetAllBatches, serviceImpl.GetAllBatches)
          .AddMethod(__Method_OpenAndSettleBatchFromPendingCapturesSpecificMerchant, serviceImpl.OpenAndSettleBatchFromPendingCapturesSpecificMerchant)
          .AddMethod(__Method_OpenAndSettleBatchFromPendingCapturesAllMerchants, serviceImpl.OpenAndSettleBatchFromPendingCapturesAllMerchants)
          .AddMethod(__Method_CancelPendingCapture, serviceImpl.CancelPendingCapture)
          .AddMethod(__Method_VerifyAndTokenizeNotPresentCard, serviceImpl.VerifyAndTokenizeNotPresentCard).Build();
    }

  }
}
#endregion
