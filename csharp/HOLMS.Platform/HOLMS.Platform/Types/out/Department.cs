// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: iam/department.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.IAM {

  /// <summary>Holder for reflection information generated from iam/department.proto</summary>
  public static partial class DepartmentReflection {

    #region Descriptor
    /// <summary>File descriptor for iam/department.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DepartmentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRpYW0vZGVwYXJ0bWVudC5wcm90bxIPaG9sbXMudHlwZXMuaWFtGh5pYW0v",
            "ZGVwYXJ0bWVudF9pbmRpY2F0b3IucHJvdG8aH3ByaW1pdGl2ZS9zZXNzaW9u",
            "X2NvbnRleHQucHJvdG8iwQEKCkRlcGFydG1lbnQSNwoJZW50aXR5X2lkGAEg",
            "ASgLMiQuaG9sbXMudHlwZXMuaWFtLkRlcGFydG1lbnRJbmRpY2F0b3ISDAoE",
            "bmFtZRgCIAEoCRIWCg5pc19ob3VzZWtlZXBlchgDIAEoCBI2CgdhY3Rpb25z",
            "GAQgAygOMiUuaG9sbXMudHlwZXMucHJpbWl0aXZlLlNlY3VyaXR5QWN0aW9u",
            "EhwKFGlzX2Nhc2hfZHJvcF9pbmNsdWRlGAUgASgIQhdaA2lhbaoCD0hPTE1T",
            "LlR5cGVzLklBTWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.IAM.DepartmentIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.SessionContextReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.IAM.Department), global::HOLMS.Types.IAM.Department.Parser, new[]{ "EntityId", "Name", "IsHousekeeper", "Actions", "IsCashDropInclude" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Department : pb::IMessage<Department> {
    private static readonly pb::MessageParser<Department> _parser = new pb::MessageParser<Department>(() => new Department());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Department> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.IAM.DepartmentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Department() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Department(Department other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      name_ = other.name_;
      isHousekeeper_ = other.isHousekeeper_;
      actions_ = other.actions_.Clone();
      isCashDropInclude_ = other.isCashDropInclude_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Department Clone() {
      return new Department(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.IAM.DepartmentIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.DepartmentIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_housekeeper" field.</summary>
    public const int IsHousekeeperFieldNumber = 3;
    private bool isHousekeeper_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsHousekeeper {
      get { return isHousekeeper_; }
      set {
        isHousekeeper_ = value;
      }
    }

    /// <summary>Field number for the "actions" field.</summary>
    public const int ActionsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Primitive.SecurityAction> _repeated_actions_codec
        = pb::FieldCodec.ForEnum(34, x => (int) x, x => (global::HOLMS.Types.Primitive.SecurityAction) x);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Primitive.SecurityAction> actions_ = new pbc::RepeatedField<global::HOLMS.Types.Primitive.SecurityAction>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Primitive.SecurityAction> Actions {
      get { return actions_; }
    }

    /// <summary>Field number for the "is_cash_drop_include" field.</summary>
    public const int IsCashDropIncludeFieldNumber = 5;
    private bool isCashDropInclude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsCashDropInclude {
      get { return isCashDropInclude_; }
      set {
        isCashDropInclude_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Department);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Department other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Name != other.Name) return false;
      if (IsHousekeeper != other.IsHousekeeper) return false;
      if(!actions_.Equals(other.actions_)) return false;
      if (IsCashDropInclude != other.IsCashDropInclude) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (IsHousekeeper != false) hash ^= IsHousekeeper.GetHashCode();
      hash ^= actions_.GetHashCode();
      if (IsCashDropInclude != false) hash ^= IsCashDropInclude.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (IsHousekeeper != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsHousekeeper);
      }
      actions_.WriteTo(output, _repeated_actions_codec);
      if (IsCashDropInclude != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsCashDropInclude);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (IsHousekeeper != false) {
        size += 1 + 1;
      }
      size += actions_.CalculateSize(_repeated_actions_codec);
      if (IsCashDropInclude != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Department other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.IAM.DepartmentIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.IsHousekeeper != false) {
        IsHousekeeper = other.IsHousekeeper;
      }
      actions_.Add(other.actions_);
      if (other.IsCashDropInclude != false) {
        IsCashDropInclude = other.IsCashDropInclude;
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
              entityId_ = new global::HOLMS.Types.IAM.DepartmentIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            IsHousekeeper = input.ReadBool();
            break;
          }
          case 34:
          case 32: {
            actions_.AddEntriesFrom(input, _repeated_actions_codec);
            break;
          }
          case 40: {
            IsCashDropInclude = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
