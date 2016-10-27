// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/guest_folio_template.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations {

  /// <summary>Holder for reflection information generated from operations/guest_folio_template.proto</summary>
  public static partial class GuestFolioTemplateReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/guest_folio_template.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GuestFolioTemplateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVvcGVyYXRpb25zL2d1ZXN0X2ZvbGlvX3RlbXBsYXRlLnByb3RvEhZob2xt",
            "cy50eXBlcy5vcGVyYXRpb25zGhRwcmltaXRpdmUvdXVpZC5wcm90byKAAQoS",
            "R3Vlc3RGb2xpb1RlbXBsYXRlEi4KCWVudGl0eV9pZBgBIAEoCzIbLmhvbG1z",
            "LnR5cGVzLnByaW1pdGl2ZS5VdWlkEg0KBXRpdGxlGAIgASgJEhQKDHJ0Zl90",
            "ZW1wbGF0ZRgDIAEoCRIVCg1odG1sX3RlbXBsYXRlGAQgASgJQiVaCm9wZXJh",
            "dGlvbnOqAhZIT0xNUy5UeXBlcy5PcGVyYXRpb25zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.UuidReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.GuestFolioTemplate), global::HOLMS.Types.Operations.GuestFolioTemplate.Parser, new[]{ "EntityId", "Title", "RtfTemplate", "HtmlTemplate" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GuestFolioTemplate : pb::IMessage<GuestFolioTemplate> {
    private static readonly pb::MessageParser<GuestFolioTemplate> _parser = new pb::MessageParser<GuestFolioTemplate>(() => new GuestFolioTemplate());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GuestFolioTemplate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.GuestFolioTemplateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GuestFolioTemplate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GuestFolioTemplate(GuestFolioTemplate other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      title_ = other.title_;
      rtfTemplate_ = other.rtfTemplate_;
      htmlTemplate_ = other.htmlTemplate_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GuestFolioTemplate Clone() {
      return new GuestFolioTemplate(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Primitive.Uuid entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.Uuid EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 2;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rtf_template" field.</summary>
    public const int RtfTemplateFieldNumber = 3;
    private string rtfTemplate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RtfTemplate {
      get { return rtfTemplate_; }
      set {
        rtfTemplate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "html_template" field.</summary>
    public const int HtmlTemplateFieldNumber = 4;
    private string htmlTemplate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HtmlTemplate {
      get { return htmlTemplate_; }
      set {
        htmlTemplate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GuestFolioTemplate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GuestFolioTemplate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Title != other.Title) return false;
      if (RtfTemplate != other.RtfTemplate) return false;
      if (HtmlTemplate != other.HtmlTemplate) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (RtfTemplate.Length != 0) hash ^= RtfTemplate.GetHashCode();
      if (HtmlTemplate.Length != 0) hash ^= HtmlTemplate.GetHashCode();
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
      if (Title.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Title);
      }
      if (RtfTemplate.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RtfTemplate);
      }
      if (HtmlTemplate.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(HtmlTemplate);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (RtfTemplate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RtfTemplate);
      }
      if (HtmlTemplate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HtmlTemplate);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GuestFolioTemplate other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Primitive.Uuid();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.RtfTemplate.Length != 0) {
        RtfTemplate = other.RtfTemplate;
      }
      if (other.HtmlTemplate.Length != 0) {
        HtmlTemplate = other.HtmlTemplate;
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
              entityId_ = new global::HOLMS.Types.Primitive.Uuid();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            Title = input.ReadString();
            break;
          }
          case 26: {
            RtfTemplate = input.ReadString();
            break;
          }
          case 34: {
            HtmlTemplate = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
