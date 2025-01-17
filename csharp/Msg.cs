// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protobuf/msg.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protomsg {

  /// <summary>Holder for reflection information generated from protobuf/msg.proto</summary>
  public static partial class MsgReflection {

    #region Descriptor
    /// <summary>File descriptor for protobuf/msg.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJwcm90b2J1Zi9tc2cucHJvdG8SCHByb3RvbXNnIkwKB01zZ0Jhc2USEAoI",
            "TW9kZVR5cGUYASABKAkSCwoDVWlkGAIgASgFEg8KB01zZ1R5cGUYAyABKAkS",
            "EQoJQ29ubmVjdElkGAQgASgFKh8KCVBob25lVHlwZRIICgRIT01FEAASCAoE",
            "V09SSxABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Protomsg.PhoneType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protomsg.MsgBase), global::Protomsg.MsgBase.Parser, new[]{ "ModeType", "Uid", "MsgType", "ConnectId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///手机类型
  ///枚举类型第一个字段必须为0
  /// </summary>
  public enum PhoneType {
    [pbr::OriginalName("HOME")] Home = 0,
    [pbr::OriginalName("WORK")] Work = 1,
  }

  #endregion

  #region Messages
  public sealed partial class MsgBase : pb::IMessage<MsgBase> {
    private static readonly pb::MessageParser<MsgBase> _parser = new pb::MessageParser<MsgBase>(() => new MsgBase());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MsgBase> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protomsg.MsgReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgBase() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgBase(MsgBase other) : this() {
      modeType_ = other.modeType_;
      uid_ = other.uid_;
      msgType_ = other.msgType_;
      connectId_ = other.connectId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgBase Clone() {
      return new MsgBase(this);
    }

    /// <summary>Field number for the "ModeType" field.</summary>
    public const int ModeTypeFieldNumber = 1;
    private string modeType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ModeType {
      get { return modeType_; }
      set {
        modeType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Uid" field.</summary>
    public const int UidFieldNumber = 2;
    private int uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "MsgType" field.</summary>
    public const int MsgTypeFieldNumber = 3;
    private string msgType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MsgType {
      get { return msgType_; }
      set {
        msgType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ConnectId" field.</summary>
    public const int ConnectIdFieldNumber = 4;
    private int connectId_;
    /// <summary>
    ///string  JsonData = 5;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ConnectId {
      get { return connectId_; }
      set {
        connectId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MsgBase);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MsgBase other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModeType != other.ModeType) return false;
      if (Uid != other.Uid) return false;
      if (MsgType != other.MsgType) return false;
      if (ConnectId != other.ConnectId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ModeType.Length != 0) hash ^= ModeType.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (MsgType.Length != 0) hash ^= MsgType.GetHashCode();
      if (ConnectId != 0) hash ^= ConnectId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ModeType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ModeType);
      }
      if (Uid != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Uid);
      }
      if (MsgType.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MsgType);
      }
      if (ConnectId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ConnectId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ModeType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ModeType);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Uid);
      }
      if (MsgType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MsgType);
      }
      if (ConnectId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ConnectId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MsgBase other) {
      if (other == null) {
        return;
      }
      if (other.ModeType.Length != 0) {
        ModeType = other.ModeType;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.MsgType.Length != 0) {
        MsgType = other.MsgType;
      }
      if (other.ConnectId != 0) {
        ConnectId = other.ConnectId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ModeType = input.ReadString();
            break;
          }
          case 16: {
            Uid = input.ReadInt32();
            break;
          }
          case 26: {
            MsgType = input.ReadString();
            break;
          }
          case 32: {
            ConnectId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
