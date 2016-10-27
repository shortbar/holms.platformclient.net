// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/reservation_note_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.RPC {

  /// <summary>Holder for reflection information generated from booking/rpc/reservation_note_svc.proto</summary>
  public static partial class ReservationNoteSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/rpc/reservation_note_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationNoteSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZib29raW5nL3JwYy9yZXNlcnZhdGlvbl9ub3RlX3N2Yy5wcm90bxIXaG9s",
            "bXMudHlwZXMuYm9va2luZy5ycGMaG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5w",
            "cm90bxouYm9va2luZy9pbmRpY2F0b3JzL3Jlc2VydmF0aW9uX2luZGljYXRv",
            "ci5wcm90bxorYm9va2luZy9yZXNlcnZhdGlvbnMvcmVzZXJ2YXRpb25fbm90",
            "ZS5wcm90bxozYm9va2luZy9pbmRpY2F0b3JzL3Jlc2VydmF0aW9uX25vdGVf",
            "aW5kaWNhdG9yLnByb3RvImYKIlJlc2VydmF0aW9uTm90ZVN2Y0dldE5vdGVz",
            "UmVzcG9uc2USQAoFbm90ZXMYASADKAsyMS5ob2xtcy50eXBlcy5ib29raW5n",
            "LnJlc2VydmF0aW9ucy5SZXNlcnZhdGlvbk5vdGUigQEKIVJlc2VydmF0aW9u",
            "Tm90ZUZ1bGZpbGxtZW50UmVxdWVzdBJGCgRub3RlGAEgASgLMjguaG9sbXMu",
            "dHlwZXMuYm9va2luZy5pbmRpY2F0b3JzLlJlc2VydmF0aW9uTm90ZUluZGlj",
            "YXRvchIUCgxpc19mdWxmaWxsZWQYAiABKAgyuQQKElJlc2VydmF0aW9uTm90",
            "ZVN2YxJoChJTZXROb3RlRnVsZmlsbG1lbnQSOi5ob2xtcy50eXBlcy5ib29r",
            "aW5nLnJwYy5SZXNlcnZhdGlvbk5vdGVGdWxmaWxsbWVudFJlcXVlc3QaFi5n",
            "b29nbGUucHJvdG9idWYuRW1wdHkSiAEKE0dldFJlc2VydmF0aW9uTm90ZXMS",
            "NC5ob2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuUmVzZXJ2YXRpb25J",
            "bmRpY2F0b3IaOy5ob2xtcy50eXBlcy5ib29raW5nLnJwYy5SZXNlcnZhdGlv",
            "bk5vdGVTdmNHZXROb3Rlc1Jlc3BvbnNlEl8KEkFkZFJlc2VydmF0aW9uTm90",
            "ZRIxLmhvbG1zLnR5cGVzLmJvb2tpbmcucmVzZXJ2YXRpb25zLlJlc2VydmF0",
            "aW9uTm90ZRoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRJiChVVcGRhdGVSZXNl",
            "cnZhdGlvbk5vdGUSMS5ob2xtcy50eXBlcy5ib29raW5nLnJlc2VydmF0aW9u",
            "cy5SZXNlcnZhdGlvbk5vdGUaFi5nb29nbGUucHJvdG9idWYuRW1wdHkSaQoV",
            "UmVtb3ZlUmVzZXJ2YXRpb25Ob3RlEjguaG9sbXMudHlwZXMuYm9va2luZy5p",
            "bmRpY2F0b3JzLlJlc2VydmF0aW9uTm90ZUluZGljYXRvchoWLmdvb2dsZS5w",
            "cm90b2J1Zi5FbXB0eUInWgtib29raW5nL3JwY6oCF0hPTE1TLlR5cGVzLkJv",
            "b2tpbmcuUlBDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Reservations.ReservationNoteReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.RPC.ReservationNoteSvcGetNotesResponse), global::HOLMS.Types.Booking.RPC.ReservationNoteSvcGetNotesResponse.Parser, new[]{ "Notes" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.RPC.ReservationNoteFulfillmentRequest), global::HOLMS.Types.Booking.RPC.ReservationNoteFulfillmentRequest.Parser, new[]{ "Note", "IsFulfilled" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationNoteSvcGetNotesResponse : pb::IMessage<ReservationNoteSvcGetNotesResponse> {
    private static readonly pb::MessageParser<ReservationNoteSvcGetNotesResponse> _parser = new pb::MessageParser<ReservationNoteSvcGetNotesResponse>(() => new ReservationNoteSvcGetNotesResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationNoteSvcGetNotesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.RPC.ReservationNoteSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteSvcGetNotesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteSvcGetNotesResponse(ReservationNoteSvcGetNotesResponse other) : this() {
      notes_ = other.notes_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteSvcGetNotesResponse Clone() {
      return new ReservationNoteSvcGetNotesResponse(this);
    }

    /// <summary>Field number for the "notes" field.</summary>
    public const int NotesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Booking.Reservations.ReservationNote> _repeated_notes_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Booking.Reservations.ReservationNote.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Booking.Reservations.ReservationNote> notes_ = new pbc::RepeatedField<global::HOLMS.Types.Booking.Reservations.ReservationNote>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Booking.Reservations.ReservationNote> Notes {
      get { return notes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationNoteSvcGetNotesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationNoteSvcGetNotesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!notes_.Equals(other.notes_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= notes_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      notes_.WriteTo(output, _repeated_notes_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += notes_.CalculateSize(_repeated_notes_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationNoteSvcGetNotesResponse other) {
      if (other == null) {
        return;
      }
      notes_.Add(other.notes_);
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
            notes_.AddEntriesFrom(input, _repeated_notes_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ReservationNoteFulfillmentRequest : pb::IMessage<ReservationNoteFulfillmentRequest> {
    private static readonly pb::MessageParser<ReservationNoteFulfillmentRequest> _parser = new pb::MessageParser<ReservationNoteFulfillmentRequest>(() => new ReservationNoteFulfillmentRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationNoteFulfillmentRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.RPC.ReservationNoteSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteFulfillmentRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteFulfillmentRequest(ReservationNoteFulfillmentRequest other) : this() {
      Note = other.note_ != null ? other.Note.Clone() : null;
      isFulfilled_ = other.isFulfilled_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteFulfillmentRequest Clone() {
      return new ReservationNoteFulfillmentRequest(this);
    }

    /// <summary>Field number for the "note" field.</summary>
    public const int NoteFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator note_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator Note {
      get { return note_; }
      set {
        note_ = value;
      }
    }

    /// <summary>Field number for the "is_fulfilled" field.</summary>
    public const int IsFulfilledFieldNumber = 2;
    private bool isFulfilled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsFulfilled {
      get { return isFulfilled_; }
      set {
        isFulfilled_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationNoteFulfillmentRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationNoteFulfillmentRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Note, other.Note)) return false;
      if (IsFulfilled != other.IsFulfilled) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (note_ != null) hash ^= Note.GetHashCode();
      if (IsFulfilled != false) hash ^= IsFulfilled.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (note_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Note);
      }
      if (IsFulfilled != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsFulfilled);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (note_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Note);
      }
      if (IsFulfilled != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationNoteFulfillmentRequest other) {
      if (other == null) {
        return;
      }
      if (other.note_ != null) {
        if (note_ == null) {
          note_ = new global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator();
        }
        Note.MergeFrom(other.Note);
      }
      if (other.IsFulfilled != false) {
        IsFulfilled = other.IsFulfilled;
      }
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
            if (note_ == null) {
              note_ = new global::HOLMS.Types.Booking.Indicators.ReservationNoteIndicator();
            }
            input.ReadMessage(note_);
            break;
          }
          case 16: {
            IsFulfilled = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
