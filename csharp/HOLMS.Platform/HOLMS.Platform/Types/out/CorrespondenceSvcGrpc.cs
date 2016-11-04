// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: crm/rpc/correspondence_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.CRM.RPC {
  public static class CorrespondenceSvc
  {
    static readonly string __ServiceName = "holms.types.crm.rpc.CorrespondenceSvc";

    static readonly Marshaller<global::HOLMS.Types.CRM.RPC.CorrespondenceRequest> __Marshaller_CorrespondenceRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.CRM.RPC.CorrespondenceRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.PropertyArrivalLetterText> __Marshaller_PropertyArrivalLetterText = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.PropertyArrivalLetterText.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> __Marshaller_CorrespondenceServiceDocumentResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Primitive.PbLocalDate> __Marshaller_PbLocalDate = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Primitive.PbLocalDate.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.Indicators.ReservationIndicator> __Marshaller_ReservationIndicator = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Indicators.ReservationIndicator.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.PropertyConfirmationLetterText> __Marshaller_PropertyConfirmationLetterText = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.PropertyConfirmationLetterText.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterText> __Marshaller_PropertyCancellationLetterText = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterText.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.CRM.RPC.CorrespondenceRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SendConfirmationLetter = new Method<global::HOLMS.Types.CRM.RPC.CorrespondenceRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "SendConfirmationLetter",
        __Marshaller_CorrespondenceRequest,
        __Marshaller_Empty);

    static readonly Method<global::HOLMS.Types.CRM.RPC.CorrespondenceRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SendCancellationEmail = new Method<global::HOLMS.Types.CRM.RPC.CorrespondenceRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "SendCancellationEmail",
        __Marshaller_CorrespondenceRequest,
        __Marshaller_Empty);

    static readonly Method<global::HOLMS.Types.CRM.RPC.CorrespondenceRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SendGuestFolio = new Method<global::HOLMS.Types.CRM.RPC.CorrespondenceRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "SendGuestFolio",
        __Marshaller_CorrespondenceRequest,
        __Marshaller_Empty);

    static readonly Method<global::HOLMS.Types.TenancyConfig.PropertyArrivalLetterText, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> __Method_PreviewArrivalLetter = new Method<global::HOLMS.Types.TenancyConfig.PropertyArrivalLetterText, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse>(
        MethodType.Unary,
        __ServiceName,
        "PreviewArrivalLetter",
        __Marshaller_PropertyArrivalLetterText,
        __Marshaller_CorrespondenceServiceDocumentResponse);

    static readonly Method<global::HOLMS.Types.Primitive.PbLocalDate, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> __Method_GetArrivalLetterDocumentsArrivingOn = new Method<global::HOLMS.Types.Primitive.PbLocalDate, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetArrivalLetterDocumentsArrivingOn",
        __Marshaller_PbLocalDate,
        __Marshaller_CorrespondenceServiceDocumentResponse);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> __Method_GetArrivalLetterDocument = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetArrivalLetterDocument",
        __Marshaller_ReservationIndicator,
        __Marshaller_CorrespondenceServiceDocumentResponse);

    static readonly Method<global::HOLMS.Types.TenancyConfig.PropertyConfirmationLetterText, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> __Method_PreviewConfirmationLetter = new Method<global::HOLMS.Types.TenancyConfig.PropertyConfirmationLetterText, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse>(
        MethodType.Unary,
        __ServiceName,
        "PreviewConfirmationLetter",
        __Marshaller_PropertyConfirmationLetterText,
        __Marshaller_CorrespondenceServiceDocumentResponse);

    static readonly Method<global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterText, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> __Method_PreviewCancellationEmail = new Method<global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterText, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse>(
        MethodType.Unary,
        __ServiceName,
        "PreviewCancellationEmail",
        __Marshaller_PropertyCancellationLetterText,
        __Marshaller_CorrespondenceServiceDocumentResponse);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> __Method_GetReservationFolioPrintDoc = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetReservationFolioPrintDoc",
        __Marshaller_ReservationIndicator,
        __Marshaller_CorrespondenceServiceDocumentResponse);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> __Method_GetReservationConfirmationPrintDoc = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetReservationConfirmationPrintDoc",
        __Marshaller_ReservationIndicator,
        __Marshaller_CorrespondenceServiceDocumentResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.CRM.RPC.CorrespondenceSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CorrespondenceSvc</summary>
    public abstract class CorrespondenceSvcBase
    {
      /// <summary>
      ///  Email
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> SendConfirmationLetter(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> SendCancellationEmail(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> SendGuestFolio(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Print (get HTML)
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> PreviewArrivalLetter(global::HOLMS.Types.TenancyConfig.PropertyArrivalLetterText request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetArrivalLetterDocumentsArrivingOn(global::HOLMS.Types.Primitive.PbLocalDate request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetArrivalLetterDocument(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> PreviewConfirmationLetter(global::HOLMS.Types.TenancyConfig.PropertyConfirmationLetterText request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> PreviewCancellationEmail(global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterText request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetReservationFolioPrintDoc(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetReservationConfirmationPrintDoc(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CorrespondenceSvc</summary>
    public class CorrespondenceSvcClient : ClientBase<CorrespondenceSvcClient>
    {
      /// <summary>Creates a new client for CorrespondenceSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CorrespondenceSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CorrespondenceSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CorrespondenceSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CorrespondenceSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CorrespondenceSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Email
      /// </summary>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SendConfirmationLetter(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SendConfirmationLetter(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Email
      /// </summary>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SendConfirmationLetter(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendConfirmationLetter, null, options, request);
      }
      /// <summary>
      ///  Email
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SendConfirmationLetterAsync(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SendConfirmationLetterAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Email
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SendConfirmationLetterAsync(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendConfirmationLetter, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SendCancellationEmail(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SendCancellationEmail(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SendCancellationEmail(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendCancellationEmail, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SendCancellationEmailAsync(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SendCancellationEmailAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SendCancellationEmailAsync(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendCancellationEmail, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SendGuestFolio(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SendGuestFolio(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SendGuestFolio(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendGuestFolio, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SendGuestFolioAsync(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SendGuestFolioAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SendGuestFolioAsync(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendGuestFolio, null, options, request);
      }
      /// <summary>
      ///  Print (get HTML)
      /// </summary>
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse PreviewArrivalLetter(global::HOLMS.Types.TenancyConfig.PropertyArrivalLetterText request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PreviewArrivalLetter(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Print (get HTML)
      /// </summary>
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse PreviewArrivalLetter(global::HOLMS.Types.TenancyConfig.PropertyArrivalLetterText request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PreviewArrivalLetter, null, options, request);
      }
      /// <summary>
      ///  Print (get HTML)
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> PreviewArrivalLetterAsync(global::HOLMS.Types.TenancyConfig.PropertyArrivalLetterText request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PreviewArrivalLetterAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Print (get HTML)
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> PreviewArrivalLetterAsync(global::HOLMS.Types.TenancyConfig.PropertyArrivalLetterText request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PreviewArrivalLetter, null, options, request);
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse GetArrivalLetterDocumentsArrivingOn(global::HOLMS.Types.Primitive.PbLocalDate request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetArrivalLetterDocumentsArrivingOn(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse GetArrivalLetterDocumentsArrivingOn(global::HOLMS.Types.Primitive.PbLocalDate request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetArrivalLetterDocumentsArrivingOn, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetArrivalLetterDocumentsArrivingOnAsync(global::HOLMS.Types.Primitive.PbLocalDate request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetArrivalLetterDocumentsArrivingOnAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetArrivalLetterDocumentsArrivingOnAsync(global::HOLMS.Types.Primitive.PbLocalDate request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetArrivalLetterDocumentsArrivingOn, null, options, request);
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse GetArrivalLetterDocument(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetArrivalLetterDocument(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse GetArrivalLetterDocument(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetArrivalLetterDocument, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetArrivalLetterDocumentAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetArrivalLetterDocumentAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetArrivalLetterDocumentAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetArrivalLetterDocument, null, options, request);
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse PreviewConfirmationLetter(global::HOLMS.Types.TenancyConfig.PropertyConfirmationLetterText request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PreviewConfirmationLetter(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse PreviewConfirmationLetter(global::HOLMS.Types.TenancyConfig.PropertyConfirmationLetterText request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PreviewConfirmationLetter, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> PreviewConfirmationLetterAsync(global::HOLMS.Types.TenancyConfig.PropertyConfirmationLetterText request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PreviewConfirmationLetterAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> PreviewConfirmationLetterAsync(global::HOLMS.Types.TenancyConfig.PropertyConfirmationLetterText request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PreviewConfirmationLetter, null, options, request);
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse PreviewCancellationEmail(global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterText request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PreviewCancellationEmail(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse PreviewCancellationEmail(global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterText request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PreviewCancellationEmail, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> PreviewCancellationEmailAsync(global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterText request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PreviewCancellationEmailAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> PreviewCancellationEmailAsync(global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterText request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PreviewCancellationEmail, null, options, request);
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse GetReservationFolioPrintDoc(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationFolioPrintDoc(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse GetReservationFolioPrintDoc(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationFolioPrintDoc, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetReservationFolioPrintDocAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationFolioPrintDocAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetReservationFolioPrintDocAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationFolioPrintDoc, null, options, request);
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse GetReservationConfirmationPrintDoc(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationConfirmationPrintDoc(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse GetReservationConfirmationPrintDoc(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationConfirmationPrintDoc, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetReservationConfirmationPrintDocAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationConfirmationPrintDocAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse> GetReservationConfirmationPrintDocAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationConfirmationPrintDoc, null, options, request);
      }
      protected override CorrespondenceSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CorrespondenceSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(CorrespondenceSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SendConfirmationLetter, serviceImpl.SendConfirmationLetter)
          .AddMethod(__Method_SendCancellationEmail, serviceImpl.SendCancellationEmail)
          .AddMethod(__Method_SendGuestFolio, serviceImpl.SendGuestFolio)
          .AddMethod(__Method_PreviewArrivalLetter, serviceImpl.PreviewArrivalLetter)
          .AddMethod(__Method_GetArrivalLetterDocumentsArrivingOn, serviceImpl.GetArrivalLetterDocumentsArrivingOn)
          .AddMethod(__Method_GetArrivalLetterDocument, serviceImpl.GetArrivalLetterDocument)
          .AddMethod(__Method_PreviewConfirmationLetter, serviceImpl.PreviewConfirmationLetter)
          .AddMethod(__Method_PreviewCancellationEmail, serviceImpl.PreviewCancellationEmail)
          .AddMethod(__Method_GetReservationFolioPrintDoc, serviceImpl.GetReservationFolioPrintDoc)
          .AddMethod(__Method_GetReservationConfirmationPrintDoc, serviceImpl.GetReservationConfirmationPrintDoc).Build();
    }

  }
}
#endregion
