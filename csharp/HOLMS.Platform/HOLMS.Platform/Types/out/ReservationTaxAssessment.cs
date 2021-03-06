// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/reservation_tax_assessment.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/reservation_tax_assessment.proto</summary>
  public static partial class ReservationTaxAssessmentReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/reservation_tax_assessment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationTaxAssessmentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZmb2xpby9yZXNlcnZhdGlvbl90YXhfYXNzZXNzbWVudC5wcm90bxIRaG9s",
            "bXMudHlwZXMuZm9saW8aGmZvbGlvL3RheF9hc3Nlc3NtZW50LnByb3RvGi5i",
            "b29raW5nL2luZGljYXRvcnMvcmVzZXJ2YXRpb25faW5kaWNhdG9yLnByb3Rv",
            "IqgBChhSZXNlcnZhdGlvblRheEFzc2Vzc21lbnQSSQoLcmVzZXJ2YXRpb24Y",
            "ASABKAsyNC5ob2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuUmVzZXJ2",
            "YXRpb25JbmRpY2F0b3ISQQoXY3VycmVudF90YXhfYXNzZXNzbWVudHMYAiAD",
            "KAsyIC5ob2xtcy50eXBlcy5mb2xpby5UYXhBc3Nlc3NtZW50QhSqAhFIT0xN",
            "Uy5UeXBlcy5Gb2xpb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Folio.TaxAssessmentReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.ReservationTaxAssessment), global::HOLMS.Types.Folio.ReservationTaxAssessment.Parser, new[]{ "Reservation", "CurrentTaxAssessments" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationTaxAssessment : pb::IMessage<ReservationTaxAssessment> {
    private static readonly pb::MessageParser<ReservationTaxAssessment> _parser = new pb::MessageParser<ReservationTaxAssessment>(() => new ReservationTaxAssessment());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationTaxAssessment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.ReservationTaxAssessmentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationTaxAssessment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationTaxAssessment(ReservationTaxAssessment other) : this() {
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      currentTaxAssessments_ = other.currentTaxAssessments_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationTaxAssessment Clone() {
      return new ReservationTaxAssessment(this);
    }

    /// <summary>Field number for the "reservation" field.</summary>
    public const int ReservationFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator Reservation {
      get { return reservation_; }
      set {
        reservation_ = value;
      }
    }

    /// <summary>Field number for the "current_tax_assessments" field.</summary>
    public const int CurrentTaxAssessmentsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.TaxAssessment> _repeated_currentTaxAssessments_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Folio.TaxAssessment.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.TaxAssessment> currentTaxAssessments_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.TaxAssessment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.TaxAssessment> CurrentTaxAssessments {
      get { return currentTaxAssessments_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationTaxAssessment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationTaxAssessment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if(!currentTaxAssessments_.Equals(other.currentTaxAssessments_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      hash ^= currentTaxAssessments_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (reservation_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Reservation);
      }
      currentTaxAssessments_.WriteTo(output, _repeated_currentTaxAssessments_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      size += currentTaxAssessments_.CalculateSize(_repeated_currentTaxAssessments_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationTaxAssessment other) {
      if (other == null) {
        return;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      currentTaxAssessments_.Add(other.currentTaxAssessments_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (reservation_ == null) {
              reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservation_);
            break;
          }
          case 18: {
            currentTaxAssessments_.AddEntriesFrom(input, _repeated_currentTaxAssessments_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
