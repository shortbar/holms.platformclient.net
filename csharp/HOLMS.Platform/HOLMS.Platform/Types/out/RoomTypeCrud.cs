// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/room_types/room_type_crud.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.RoomTypes {

  /// <summary>Holder for reflection information generated from supply/room_types/room_type_crud.proto</summary>
  public static partial class RoomTypeCrudReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/room_types/room_type_crud.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomTypeCrudReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZzdXBwbHkvcm9vbV90eXBlcy9yb29tX3R5cGVfY3J1ZC5wcm90bxIdaG9s",
            "bXMudHlwZXMuc3VwcGx5LnJvb21fdHlwZXMaG3ByaW1pdGl2ZS9jcnVkX2Fj",
            "dGlvbi5wcm90bxohc3VwcGx5L3Jvb21fdHlwZXMvcm9vbV90eXBlLnByb3Rv",
            "IpUBCgxSb29tVHlwZUNydWQSEQoJal93X3Rva2VuGAEgASgJEjYKC2NydWRf",
            "YWN0aW9uGAIgASgOMiEuaG9sbXMudHlwZXMucHJpbWl0aXZlLkNydWRBY3Rp",
            "b24SOgoJcm9vbV90eXBlGAMgASgLMicuaG9sbXMudHlwZXMuc3VwcGx5LnJv",
            "b21fdHlwZXMuUm9vbVR5cGVCMVoQc3VwcGx5L3Jvb210eXBlc6oCHEhPTE1T",
            "LlR5cGVzLlN1cHBseS5Sb29tVHlwZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.CrudActionReflection.Descriptor, global::HOLMS.Types.Supply.RoomTypes.RoomTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RoomTypes.RoomTypeCrud), global::HOLMS.Types.Supply.RoomTypes.RoomTypeCrud.Parser, new[]{ "JWToken", "CrudAction", "RoomType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RoomTypeCrud : pb::IMessage<RoomTypeCrud> {
    private static readonly pb::MessageParser<RoomTypeCrud> _parser = new pb::MessageParser<RoomTypeCrud>(() => new RoomTypeCrud());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomTypeCrud> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RoomTypes.RoomTypeCrudReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomTypeCrud() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomTypeCrud(RoomTypeCrud other) : this() {
      jWToken_ = other.jWToken_;
      crudAction_ = other.crudAction_;
      RoomType = other.roomType_ != null ? other.RoomType.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomTypeCrud Clone() {
      return new RoomTypeCrud(this);
    }

    /// <summary>Field number for the "j_w_token" field.</summary>
    public const int JWTokenFieldNumber = 1;
    private string jWToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JWToken {
      get { return jWToken_; }
      set {
        jWToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "crud_action" field.</summary>
    public const int CrudActionFieldNumber = 2;
    private global::HOLMS.Types.Primitive.CrudAction crudAction_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.CrudAction CrudAction {
      get { return crudAction_; }
      set {
        crudAction_ = value;
      }
    }

    /// <summary>Field number for the "room_type" field.</summary>
    public const int RoomTypeFieldNumber = 3;
    private global::HOLMS.Types.Supply.RoomTypes.RoomType roomType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RoomTypes.RoomType RoomType {
      get { return roomType_; }
      set {
        roomType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomTypeCrud);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomTypeCrud other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JWToken != other.JWToken) return false;
      if (CrudAction != other.CrudAction) return false;
      if (!object.Equals(RoomType, other.RoomType)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (JWToken.Length != 0) hash ^= JWToken.GetHashCode();
      if (CrudAction != 0) hash ^= CrudAction.GetHashCode();
      if (roomType_ != null) hash ^= RoomType.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (JWToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JWToken);
      }
      if (CrudAction != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) CrudAction);
      }
      if (roomType_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RoomType);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (JWToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JWToken);
      }
      if (CrudAction != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CrudAction);
      }
      if (roomType_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoomType);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomTypeCrud other) {
      if (other == null) {
        return;
      }
      if (other.JWToken.Length != 0) {
        JWToken = other.JWToken;
      }
      if (other.CrudAction != 0) {
        CrudAction = other.CrudAction;
      }
      if (other.roomType_ != null) {
        if (roomType_ == null) {
          roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomType();
        }
        RoomType.MergeFrom(other.RoomType);
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
            JWToken = input.ReadString();
            break;
          }
          case 16: {
            crudAction_ = (global::HOLMS.Types.Primitive.CrudAction) input.ReadEnum();
            break;
          }
          case 26: {
            if (roomType_ == null) {
              roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomType();
            }
            input.ReadMessage(roomType_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
