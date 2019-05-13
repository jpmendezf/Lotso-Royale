// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: HotMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HotMessage.proto</summary>
public static partial class HotMessageReflection {

  #region Descriptor
  /// <summary>File descriptor for HotMessage.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HotMessageReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBIb3RNZXNzYWdlLnByb3RvIjYKB01lc3NhZ2USDwoHbXNnVHlwZRgBIAEo",
          "BRILCgNtc2cYAiABKAwSDQoFYWdyZWUYAyABKAhiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Message), global::Message.Parser, new[]{ "MsgType", "Msg", "Agree" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Message : pb::IMessage<Message> {
  private static readonly pb::MessageParser<Message> _parser = new pb::MessageParser<Message>(() => new Message());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Message> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HotMessageReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Message() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Message(Message other) : this() {
    msgType_ = other.msgType_;
    msg_ = other.msg_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Message Clone() {
    return new Message(this);
  }

  /// <summary>Field number for the "msgType" field.</summary>
  public const int MsgTypeFieldNumber = 1;
  private int msgType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int MsgType {
    get { return msgType_; }
    set {
      msgType_ = value;
    }
  }

  /// <summary>Field number for the "msg" field.</summary>
  public const int MsgFieldNumber = 2;
  private pb::ByteString msg_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Msg {
    get { return msg_; }
    set {
      msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Message);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Message other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MsgType != other.MsgType) return false;
    if (Msg != other.Msg) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (MsgType != 0) hash ^= MsgType.GetHashCode();
    if (Msg.Length != 0) hash ^= Msg.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (MsgType != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(MsgType);
    }
    if (Msg.Length != 0) {
      output.WriteRawTag(18);
      output.WriteBytes(Msg);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (MsgType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(MsgType);
    }
    if (Msg.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Msg);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Message other) {
    if (other == null) {
      return;
    }
    if (other.MsgType != 0) {
      MsgType = other.MsgType;
    }
    if (other.Msg.Length != 0) {
      Msg = other.Msg;
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
          MsgType = input.ReadInt32();
          break;
        }
        case 18: {
          Msg = input.ReadBytes();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
