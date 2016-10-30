// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: reporting/rpc/front_desk_reporting_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Reporting.RPC {
  public static class FrontDeskReportingSvc
  {
    static readonly string __ServiceName = "holms.types.reporting.rpc.FrontDeskReportingSvc";

    static readonly Marshaller<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest> __Marshaller_FrontDeskReportingSvcRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> __Marshaller_FrontDeskReportingSvcReportResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcInHouseGuestsRequest> __Marshaller_FrontDeskReportingSvcInHouseGuestsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcInHouseGuestsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest> __Marshaller_FrontDeskReportingSvcHousekeepingRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest, global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> __Method_GetArrivalsReport = new Method<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest, global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetArrivalsReport",
        __Marshaller_FrontDeskReportingSvcRequest,
        __Marshaller_FrontDeskReportingSvcReportResponse);

    static readonly Method<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest, global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> __Method_GetDeparturesReport = new Method<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest, global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetDeparturesReport",
        __Marshaller_FrontDeskReportingSvcRequest,
        __Marshaller_FrontDeskReportingSvcReportResponse);

    static readonly Method<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcInHouseGuestsRequest, global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> __Method_GetInHouseGuestsReport = new Method<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcInHouseGuestsRequest, global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetInHouseGuestsReport",
        __Marshaller_FrontDeskReportingSvcInHouseGuestsRequest,
        __Marshaller_FrontDeskReportingSvcReportResponse);

    static readonly Method<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest, global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> __Method_GetNoShowsReport = new Method<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest, global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetNoShowsReport",
        __Marshaller_FrontDeskReportingSvcRequest,
        __Marshaller_FrontDeskReportingSvcReportResponse);

    static readonly Method<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest, global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> __Method_GetHousekeepingAssignmentsReport = new Method<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest, global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetHousekeepingAssignmentsReport",
        __Marshaller_FrontDeskReportingSvcHousekeepingRequest,
        __Marshaller_FrontDeskReportingSvcReportResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FrontDeskReportingSvc</summary>
    public abstract class FrontDeskReportingSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetArrivalsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetDeparturesReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetInHouseGuestsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcInHouseGuestsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetNoShowsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetHousekeepingAssignmentsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FrontDeskReportingSvc</summary>
    public class FrontDeskReportingSvcClient : ClientBase<FrontDeskReportingSvcClient>
    {
      /// <summary>Creates a new client for FrontDeskReportingSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public FrontDeskReportingSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FrontDeskReportingSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public FrontDeskReportingSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected FrontDeskReportingSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected FrontDeskReportingSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse GetArrivalsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetArrivalsReport(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse GetArrivalsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetArrivalsReport, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetArrivalsReportAsync(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetArrivalsReportAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetArrivalsReportAsync(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetArrivalsReport, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse GetDeparturesReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetDeparturesReport(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse GetDeparturesReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetDeparturesReport, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetDeparturesReportAsync(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetDeparturesReportAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetDeparturesReportAsync(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetDeparturesReport, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse GetInHouseGuestsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcInHouseGuestsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetInHouseGuestsReport(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse GetInHouseGuestsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcInHouseGuestsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetInHouseGuestsReport, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetInHouseGuestsReportAsync(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcInHouseGuestsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetInHouseGuestsReportAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetInHouseGuestsReportAsync(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcInHouseGuestsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetInHouseGuestsReport, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse GetNoShowsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetNoShowsReport(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse GetNoShowsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetNoShowsReport, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetNoShowsReportAsync(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetNoShowsReportAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetNoShowsReportAsync(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetNoShowsReport, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse GetHousekeepingAssignmentsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetHousekeepingAssignmentsReport(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse GetHousekeepingAssignmentsReport(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetHousekeepingAssignmentsReport, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetHousekeepingAssignmentsReportAsync(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetHousekeepingAssignmentsReportAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse> GetHousekeepingAssignmentsReportAsync(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetHousekeepingAssignmentsReport, null, options, request);
      }
      protected override FrontDeskReportingSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FrontDeskReportingSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(FrontDeskReportingSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetArrivalsReport, serviceImpl.GetArrivalsReport)
          .AddMethod(__Method_GetDeparturesReport, serviceImpl.GetDeparturesReport)
          .AddMethod(__Method_GetInHouseGuestsReport, serviceImpl.GetInHouseGuestsReport)
          .AddMethod(__Method_GetNoShowsReport, serviceImpl.GetNoShowsReport)
          .AddMethod(__Method_GetHousekeepingAssignmentsReport, serviceImpl.GetHousekeepingAssignmentsReport).Build();
    }

  }
}
#endregion
