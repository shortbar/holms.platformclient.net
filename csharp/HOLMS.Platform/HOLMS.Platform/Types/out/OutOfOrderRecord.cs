// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/out_of_order/out_of_order_record.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.OutOfOrder {

  /// <summary>Holder for reflection information generated from operations/out_of_order/out_of_order_record.proto</summary>
  public static partial class OutOfOrderRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/out_of_order/out_of_order_record.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OutOfOrderRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFvcGVyYXRpb25zL291dF9vZl9vcmRlci9vdXRfb2Zfb3JkZXJfcmVjb3Jk",
            "LnByb3RvEiNob2xtcy50eXBlcy5vcGVyYXRpb25zLm91dF9vZl9vcmRlchof",
            "Z29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxoqcHJpbWl0aXZlL3Bi",
            "X2luY2x1c2l2ZV9vcHNkYXRlX3JhbmdlLnByb3RvGjtvcGVyYXRpb25zL291",
            "dF9vZl9vcmRlci9vdXRfb2Zfb3JkZXJfcmVjb3JkX2luZGljYXRvci5wcm90",
            "bxobb3BlcmF0aW9ucy9yb29tcy9yb29tLnByb3RvGhZpYW0vc3RhZmZfbWVt",
            "YmVyLnByb3RvIv8CChBPdXRPZk9yZGVyUmVjb3JkElEKCWVudGl0eV9pZBgB",
            "IAEoCzI+LmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMub3V0X29mX29yZGVyLk91",
            "dE9mT3JkZXJSZWNvcmRJbmRpY2F0b3ISDgoGcmVhc29uGAIgASgJEkIKCmRh",
            "dGVfcmFuZ2UYAyABKAsyLi5ob2xtcy50eXBlcy5wcmltaXRpdmUuUGJJbmNs",
            "dXNpdmVPcHNkYXRlUmFuZ2USMAoKZW50ZXJlZF9ieRgEIAEoCzIcLmhvbG1z",
            "LnR5cGVzLmlhbS5TdGFmZk1lbWJlchIwCgp1cGRhdGVkX2J5GAUgASgLMhwu",
            "aG9sbXMudHlwZXMuaWFtLlN0YWZmTWVtYmVyEi4KCnVwZGF0ZWRfYXQYBiAB",
            "KAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEjAKBHJvb20YByABKAsy",
            "Ii5ob2xtcy50eXBlcy5vcGVyYXRpb25zLnJvb21zLlJvb21CO1oVb3BlcmF0",
            "aW9ucy9vdXRvZm9yZGVyqgIhSE9MTVMuVHlwZXMuT3BlcmF0aW9ucy5PdXRP",
            "Zk9yZGVyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicatorReflection.Descriptor, global::HOLMS.Types.Operations.Rooms.RoomReflection.Descriptor, global::HOLMS.Types.IAM.StaffMemberReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord), global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord.Parser, new[]{ "EntityId", "Reason", "DateRange", "EnteredBy", "UpdatedBy", "UpdatedAt", "Room" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OutOfOrderRecord : pb::IMessage<OutOfOrderRecord> {
    private static readonly pb::MessageParser<OutOfOrderRecord> _parser = new pb::MessageParser<OutOfOrderRecord>(() => new OutOfOrderRecord());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OutOfOrderRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecord(OutOfOrderRecord other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      reason_ = other.reason_;
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
      EnteredBy = other.enteredBy_ != null ? other.EnteredBy.Clone() : null;
      UpdatedBy = other.updatedBy_ != null ? other.UpdatedBy.Clone() : null;
      UpdatedAt = other.updatedAt_ != null ? other.UpdatedAt.Clone() : null;
      Room = other.room_ != null ? other.Room.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecord Clone() {
      return new OutOfOrderRecord(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 2;
    private string reason_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Reason {
      get { return reason_; }
      set {
        reason_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 3;
    private global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    /// <summary>Field number for the "entered_by" field.</summary>
    public const int EnteredByFieldNumber = 4;
    private global::HOLMS.Types.IAM.StaffMember enteredBy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.StaffMember EnteredBy {
      get { return enteredBy_; }
      set {
        enteredBy_ = value;
      }
    }

    /// <summary>Field number for the "updated_by" field.</summary>
    public const int UpdatedByFieldNumber = 5;
    private global::HOLMS.Types.IAM.StaffMember updatedBy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.StaffMember UpdatedBy {
      get { return updatedBy_; }
      set {
        updatedBy_ = value;
      }
    }

    /// <summary>Field number for the "updated_at" field.</summary>
    public const int UpdatedAtFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updatedAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdatedAt {
      get { return updatedAt_; }
      set {
        updatedAt_ = value;
      }
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 7;
    private global::HOLMS.Types.Operations.Rooms.Room room_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.Room Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OutOfOrderRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OutOfOrderRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Reason != other.Reason) return false;
      if (!object.Equals(DateRange, other.DateRange)) return false;
      if (!object.Equals(EnteredBy, other.EnteredBy)) return false;
      if (!object.Equals(UpdatedBy, other.UpdatedBy)) return false;
      if (!object.Equals(UpdatedAt, other.UpdatedAt)) return false;
      if (!object.Equals(Room, other.Room)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (Reason.Length != 0) hash ^= Reason.GetHashCode();
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      if (enteredBy_ != null) hash ^= EnteredBy.GetHashCode();
      if (updatedBy_ != null) hash ^= UpdatedBy.GetHashCode();
      if (updatedAt_ != null) hash ^= UpdatedAt.GetHashCode();
      if (room_ != null) hash ^= Room.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (entityId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EntityId);
      }
      if (Reason.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Reason);
      }
      if (dateRange_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DateRange);
      }
      if (enteredBy_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(EnteredBy);
      }
      if (updatedBy_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpdatedBy);
      }
      if (updatedAt_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(UpdatedAt);
      }
      if (room_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Room);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (Reason.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reason);
      }
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      if (enteredBy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnteredBy);
      }
      if (updatedBy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdatedBy);
      }
      if (updatedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdatedAt);
      }
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OutOfOrderRecord other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.Reason.Length != 0) {
        Reason = other.Reason;
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
      }
      if (other.enteredBy_ != null) {
        if (enteredBy_ == null) {
          enteredBy_ = new global::HOLMS.Types.IAM.StaffMember();
        }
        EnteredBy.MergeFrom(other.EnteredBy);
      }
      if (other.updatedBy_ != null) {
        if (updatedBy_ == null) {
          updatedBy_ = new global::HOLMS.Types.IAM.StaffMember();
        }
        UpdatedBy.MergeFrom(other.UpdatedBy);
      }
      if (other.updatedAt_ != null) {
        if (updatedAt_ == null) {
          updatedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdatedAt.MergeFrom(other.UpdatedAt);
      }
      if (other.room_ != null) {
        if (room_ == null) {
          room_ = new global::HOLMS.Types.Operations.Rooms.Room();
        }
        Room.MergeFrom(other.Room);
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
            if (entityId_ == null) {
              entityId_ = new global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            Reason = input.ReadString();
            break;
          }
          case 26: {
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
            }
            input.ReadMessage(dateRange_);
            break;
          }
          case 34: {
            if (enteredBy_ == null) {
              enteredBy_ = new global::HOLMS.Types.IAM.StaffMember();
            }
            input.ReadMessage(enteredBy_);
            break;
          }
          case 42: {
            if (updatedBy_ == null) {
              updatedBy_ = new global::HOLMS.Types.IAM.StaffMember();
            }
            input.ReadMessage(updatedBy_);
            break;
          }
          case 50: {
            if (updatedAt_ == null) {
              updatedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(updatedAt_);
            break;
          }
          case 58: {
            if (room_ == null) {
              room_ = new global::HOLMS.Types.Operations.Rooms.Room();
            }
            input.ReadMessage(room_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
