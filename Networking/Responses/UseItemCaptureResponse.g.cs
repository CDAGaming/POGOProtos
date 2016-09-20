// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/UseItemCaptureResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemCaptureResponse.proto</summary>
  public static partial class UseItemCaptureResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/UseItemCaptureResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemCaptureResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VzZUl0ZW1DYXB0",
            "dXJlUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
            "b25zZXMisQEKFlVzZUl0ZW1DYXB0dXJlUmVzcG9uc2USDwoHc3VjY2VzcxgB",
            "IAEoCBIZChFpdGVtX2NhcHR1cmVfbXVsdBgCIAEoARIWCg5pdGVtX2ZsZWVf",
            "bXVsdBgDIAEoARIVCg1zdG9wX21vdmVtZW50GAQgASgIEhMKC3N0b3BfYXR0",
            "YWNrGAUgASgIEhIKCnRhcmdldF9tYXgYBiABKAgSEwoLdGFyZ2V0X3Nsb3cY",
            "ByABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.UseItemCaptureResponse), global::POGOProtos.Networking.Responses.UseItemCaptureResponse.Parser, new[]{ "Success", "ItemCaptureMult", "ItemFleeMult", "StopMovement", "StopAttack", "TargetMax", "TargetSlow" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UseItemCaptureResponse : pb::IMessage<UseItemCaptureResponse> {
    private static readonly pb::MessageParser<UseItemCaptureResponse> _parser = new pb::MessageParser<UseItemCaptureResponse>(() => new UseItemCaptureResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UseItemCaptureResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.UseItemCaptureResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemCaptureResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemCaptureResponse(UseItemCaptureResponse other) : this() {
      success_ = other.success_;
      itemCaptureMult_ = other.itemCaptureMult_;
      itemFleeMult_ = other.itemFleeMult_;
      stopMovement_ = other.stopMovement_;
      stopAttack_ = other.stopAttack_;
      targetMax_ = other.targetMax_;
      targetSlow_ = other.targetSlow_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemCaptureResponse Clone() {
      return new UseItemCaptureResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "item_capture_mult" field.</summary>
    public const int ItemCaptureMultFieldNumber = 2;
    private double itemCaptureMult_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ItemCaptureMult {
      get { return itemCaptureMult_; }
      set {
        itemCaptureMult_ = value;
      }
    }

    /// <summary>Field number for the "item_flee_mult" field.</summary>
    public const int ItemFleeMultFieldNumber = 3;
    private double itemFleeMult_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ItemFleeMult {
      get { return itemFleeMult_; }
      set {
        itemFleeMult_ = value;
      }
    }

    /// <summary>Field number for the "stop_movement" field.</summary>
    public const int StopMovementFieldNumber = 4;
    private bool stopMovement_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool StopMovement {
      get { return stopMovement_; }
      set {
        stopMovement_ = value;
      }
    }

    /// <summary>Field number for the "stop_attack" field.</summary>
    public const int StopAttackFieldNumber = 5;
    private bool stopAttack_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool StopAttack {
      get { return stopAttack_; }
      set {
        stopAttack_ = value;
      }
    }

    /// <summary>Field number for the "target_max" field.</summary>
    public const int TargetMaxFieldNumber = 6;
    private bool targetMax_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool TargetMax {
      get { return targetMax_; }
      set {
        targetMax_ = value;
      }
    }

    /// <summary>Field number for the "target_slow" field.</summary>
    public const int TargetSlowFieldNumber = 7;
    private bool targetSlow_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool TargetSlow {
      get { return targetSlow_; }
      set {
        targetSlow_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UseItemCaptureResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UseItemCaptureResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      if (ItemCaptureMult != other.ItemCaptureMult) return false;
      if (ItemFleeMult != other.ItemFleeMult) return false;
      if (StopMovement != other.StopMovement) return false;
      if (StopAttack != other.StopAttack) return false;
      if (TargetMax != other.TargetMax) return false;
      if (TargetSlow != other.TargetSlow) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      if (ItemCaptureMult != 0D) hash ^= ItemCaptureMult.GetHashCode();
      if (ItemFleeMult != 0D) hash ^= ItemFleeMult.GetHashCode();
      if (StopMovement != false) hash ^= StopMovement.GetHashCode();
      if (StopAttack != false) hash ^= StopAttack.GetHashCode();
      if (TargetMax != false) hash ^= TargetMax.GetHashCode();
      if (TargetSlow != false) hash ^= TargetSlow.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      if (ItemCaptureMult != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(ItemCaptureMult);
      }
      if (ItemFleeMult != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(ItemFleeMult);
      }
      if (StopMovement != false) {
        output.WriteRawTag(32);
        output.WriteBool(StopMovement);
      }
      if (StopAttack != false) {
        output.WriteRawTag(40);
        output.WriteBool(StopAttack);
      }
      if (TargetMax != false) {
        output.WriteRawTag(48);
        output.WriteBool(TargetMax);
      }
      if (TargetSlow != false) {
        output.WriteRawTag(56);
        output.WriteBool(TargetSlow);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      if (ItemCaptureMult != 0D) {
        size += 1 + 8;
      }
      if (ItemFleeMult != 0D) {
        size += 1 + 8;
      }
      if (StopMovement != false) {
        size += 1 + 1;
      }
      if (StopAttack != false) {
        size += 1 + 1;
      }
      if (TargetMax != false) {
        size += 1 + 1;
      }
      if (TargetSlow != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UseItemCaptureResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      if (other.ItemCaptureMult != 0D) {
        ItemCaptureMult = other.ItemCaptureMult;
      }
      if (other.ItemFleeMult != 0D) {
        ItemFleeMult = other.ItemFleeMult;
      }
      if (other.StopMovement != false) {
        StopMovement = other.StopMovement;
      }
      if (other.StopAttack != false) {
        StopAttack = other.StopAttack;
      }
      if (other.TargetMax != false) {
        TargetMax = other.TargetMax;
      }
      if (other.TargetSlow != false) {
        TargetSlow = other.TargetSlow;
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
          case 8: {
            Success = input.ReadBool();
            break;
          }
          case 17: {
            ItemCaptureMult = input.ReadDouble();
            break;
          }
          case 25: {
            ItemFleeMult = input.ReadDouble();
            break;
          }
          case 32: {
            StopMovement = input.ReadBool();
            break;
          }
          case 40: {
            StopAttack = input.ReadBool();
            break;
          }
          case 48: {
            TargetMax = input.ReadBool();
            break;
          }
          case 56: {
            TargetSlow = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
