// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/cards/card_authorization_state.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Cards {

  /// <summary>Holder for reflection information generated from money/cards/card_authorization_state.proto</summary>
  public static partial class CardAuthorizationStateReflection {

    #region Descriptor
    /// <summary>File descriptor for money/cards/card_authorization_state.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CardAuthorizationStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ciptb25leS9jYXJkcy9jYXJkX2F1dGhvcml6YXRpb25fc3RhdGUucHJvdG8S",
            "F2hvbG1zLnR5cGVzLm1vbmV5LmNhcmRzKq0BChZDYXJkQXV0aG9yaXphdGlv",
            "blN0YXRlEiEKHUNBUkRfQVVUSE9SSVpBVElPTl9TVEFURV9PUEVOEAASJQoh",
            "Q0FSRF9BVVRIT1JJWkFUSU9OX1NUQVRFX0RFQ0xJTkVEEAESJAogQ0FSRF9B",
            "VVRIT1JJWkFUSU9OX1NUQVRFX0NIQVJHRUQQAhIjCh9DQVJEX0FVVEhPUkla",
            "QVRJT05fU1RBVEVfVk9JREVEEANCJ1oLbW9uZXkvY2FyZHOqAhdIT0xNUy5U",
            "eXBlcy5Nb25leS5DYXJkc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Money.Cards.CardAuthorizationState), }, null));
    }
    #endregion

  }
  #region Enums
  public enum CardAuthorizationState {
    [pbr::OriginalName("CARD_AUTHORIZATION_STATE_OPEN")] Open = 0,
    [pbr::OriginalName("CARD_AUTHORIZATION_STATE_DECLINED")] Declined = 1,
    [pbr::OriginalName("CARD_AUTHORIZATION_STATE_CHARGED")] Charged = 2,
    [pbr::OriginalName("CARD_AUTHORIZATION_STATE_VOIDED")] Voided = 3,
  }

  #endregion

}

#endregion Designer generated code
