// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Pb {

  /// <summary>Holder for reflection information generated from Protobuf.proto</summary>
  public static partial class ProtobufReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtobufReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5Qcm90b2J1Zi5wcm90bxICcGIiUAoQUGxheWVyU2VsZWN0RGF0YRIPCgdm",
            "YWN0aW9uGAQgASgFEhQKDGlzU2VsZWN0RG9uZRgFIAEoCBIVCg1hbGxTZWxl",
            "Y3REb25lGAYgASgIImIKClNlbGVjdERhdGESDQoFaW5kZXgYASABKAUSEgoK",
            "cGxheWVyTmFtZRgCIAEoCRIPCgdjaGF0TWVzGAMgASgJEg8KB2ZhY3Rpb24Y",
            "BiABKAUSDwoHaXNSZWFkeRgHIAEoCCKPAwoJUGJNZXNzYWdlEgwKBG5hbWUY",
            "ASABKAkSHgoDY21kGAIgASgOMhEucGIuUGJNZXNzYWdlLkNNRBIoCghjbWRN",
            "YXRjaBgDIAEoDjIWLnBiLlBiTWVzc2FnZS5DbWRNYXRjaBImCgdjbWRSb29t",
            "GAQgASgOMhUucGIuUGJNZXNzYWdlLkNtZFJvb20SIgoKc2VsZWN0RGF0YRgF",
            "IAEoCzIOLnBiLlNlbGVjdERhdGESEwoLbG9hZFBlcmNlbnQYBiABKAUiJQoD",
            "Q01EEgkKBWxvZ2luEAASCQoFbWF0Y2gQARIICgRyb29tEAIiKAoIQ21kTWF0",
            "Y2gSDQoJam9pbk1hdGNoEAASDQoJcXVpdE1hdGNoEAEieAoHQ21kUm9vbRIL",
            "Cgdjb25maXJtEAASCgoGc2VsZWN0EAESDgoKc2VsZWN0RGF0ZRACEggKBGxv",
            "YWQQAxIMCghsb2FkRGF0YRAEEg4KCmZpZ2h0U3RhcnQQBRINCglmaWdodERh",
            "dGEQBhINCglkaXNtaXNzZWQQB0IGWgQuL3BiYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.PlayerSelectData), global::Pb.PlayerSelectData.Parser, new[]{ "Faction", "IsSelectDone", "AllSelectDone" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.SelectData), global::Pb.SelectData.Parser, new[]{ "Index", "PlayerName", "ChatMes", "Faction", "IsReady" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.PbMessage), global::Pb.PbMessage.Parser, new[]{ "Name", "Cmd", "CmdMatch", "CmdRoom", "SelectData", "LoadPercent" }, null, new[]{ typeof(global::Pb.PbMessage.Types.CMD), typeof(global::Pb.PbMessage.Types.CmdMatch), typeof(global::Pb.PbMessage.Types.CmdRoom) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// this is a comment 
  /// </summary>
  public sealed partial class PlayerSelectData : pb::IMessage<PlayerSelectData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerSelectData> _parser = new pb::MessageParser<PlayerSelectData>(() => new PlayerSelectData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerSelectData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.ProtobufReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSelectData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSelectData(PlayerSelectData other) : this() {
      faction_ = other.faction_;
      isSelectDone_ = other.isSelectDone_;
      allSelectDone_ = other.allSelectDone_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSelectData Clone() {
      return new PlayerSelectData(this);
    }

    /// <summary>Field number for the "faction" field.</summary>
    public const int FactionFieldNumber = 4;
    private int faction_;
    /// <summary>
    ///具体的阵营选择还没写
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Faction {
      get { return faction_; }
      set {
        faction_ = value;
      }
    }

    /// <summary>Field number for the "isSelectDone" field.</summary>
    public const int IsSelectDoneFieldNumber = 5;
    private bool isSelectDone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSelectDone {
      get { return isSelectDone_; }
      set {
        isSelectDone_ = value;
      }
    }

    /// <summary>Field number for the "allSelectDone" field.</summary>
    public const int AllSelectDoneFieldNumber = 6;
    private bool allSelectDone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AllSelectDone {
      get { return allSelectDone_; }
      set {
        allSelectDone_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerSelectData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerSelectData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Faction != other.Faction) return false;
      if (IsSelectDone != other.IsSelectDone) return false;
      if (AllSelectDone != other.AllSelectDone) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Faction != 0) hash ^= Faction.GetHashCode();
      if (IsSelectDone != false) hash ^= IsSelectDone.GetHashCode();
      if (AllSelectDone != false) hash ^= AllSelectDone.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Faction != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Faction);
      }
      if (IsSelectDone != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsSelectDone);
      }
      if (AllSelectDone != false) {
        output.WriteRawTag(48);
        output.WriteBool(AllSelectDone);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Faction != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Faction);
      }
      if (IsSelectDone != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsSelectDone);
      }
      if (AllSelectDone != false) {
        output.WriteRawTag(48);
        output.WriteBool(AllSelectDone);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Faction != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Faction);
      }
      if (IsSelectDone != false) {
        size += 1 + 1;
      }
      if (AllSelectDone != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerSelectData other) {
      if (other == null) {
        return;
      }
      if (other.Faction != 0) {
        Faction = other.Faction;
      }
      if (other.IsSelectDone != false) {
        IsSelectDone = other.IsSelectDone;
      }
      if (other.AllSelectDone != false) {
        AllSelectDone = other.AllSelectDone;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 32: {
            Faction = input.ReadInt32();
            break;
          }
          case 40: {
            IsSelectDone = input.ReadBool();
            break;
          }
          case 48: {
            AllSelectDone = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 32: {
            Faction = input.ReadInt32();
            break;
          }
          case 40: {
            IsSelectDone = input.ReadBool();
            break;
          }
          case 48: {
            AllSelectDone = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SelectData : pb::IMessage<SelectData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SelectData> _parser = new pb::MessageParser<SelectData>(() => new SelectData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SelectData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.ProtobufReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectData(SelectData other) : this() {
      index_ = other.index_;
      playerName_ = other.playerName_;
      chatMes_ = other.chatMes_;
      faction_ = other.faction_;
      isReady_ = other.isReady_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectData Clone() {
      return new SelectData(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 1;
    private int index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "playerName" field.</summary>
    public const int PlayerNameFieldNumber = 2;
    private string playerName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PlayerName {
      get { return playerName_; }
      set {
        playerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "chatMes" field.</summary>
    public const int ChatMesFieldNumber = 3;
    private string chatMes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ChatMes {
      get { return chatMes_; }
      set {
        chatMes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "faction" field.</summary>
    public const int FactionFieldNumber = 6;
    private int faction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Faction {
      get { return faction_; }
      set {
        faction_ = value;
      }
    }

    /// <summary>Field number for the "isReady" field.</summary>
    public const int IsReadyFieldNumber = 7;
    private bool isReady_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsReady {
      get { return isReady_; }
      set {
        isReady_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SelectData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SelectData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if (PlayerName != other.PlayerName) return false;
      if (ChatMes != other.ChatMes) return false;
      if (Faction != other.Faction) return false;
      if (IsReady != other.IsReady) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0) hash ^= Index.GetHashCode();
      if (PlayerName.Length != 0) hash ^= PlayerName.GetHashCode();
      if (ChatMes.Length != 0) hash ^= ChatMes.GetHashCode();
      if (Faction != 0) hash ^= Faction.GetHashCode();
      if (IsReady != false) hash ^= IsReady.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Index != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Index);
      }
      if (PlayerName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PlayerName);
      }
      if (ChatMes.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ChatMes);
      }
      if (Faction != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Faction);
      }
      if (IsReady != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsReady);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Index != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Index);
      }
      if (PlayerName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PlayerName);
      }
      if (ChatMes.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ChatMes);
      }
      if (Faction != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Faction);
      }
      if (IsReady != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsReady);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
      }
      if (PlayerName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerName);
      }
      if (ChatMes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChatMes);
      }
      if (Faction != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Faction);
      }
      if (IsReady != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SelectData other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.PlayerName.Length != 0) {
        PlayerName = other.PlayerName;
      }
      if (other.ChatMes.Length != 0) {
        ChatMes = other.ChatMes;
      }
      if (other.Faction != 0) {
        Faction = other.Faction;
      }
      if (other.IsReady != false) {
        IsReady = other.IsReady;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Index = input.ReadInt32();
            break;
          }
          case 18: {
            PlayerName = input.ReadString();
            break;
          }
          case 26: {
            ChatMes = input.ReadString();
            break;
          }
          case 48: {
            Faction = input.ReadInt32();
            break;
          }
          case 56: {
            IsReady = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Index = input.ReadInt32();
            break;
          }
          case 18: {
            PlayerName = input.ReadString();
            break;
          }
          case 26: {
            ChatMes = input.ReadString();
            break;
          }
          case 48: {
            Faction = input.ReadInt32();
            break;
          }
          case 56: {
            IsReady = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class PbMessage : pb::IMessage<PbMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PbMessage> _parser = new pb::MessageParser<PbMessage>(() => new PbMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PbMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.ProtobufReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PbMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PbMessage(PbMessage other) : this() {
      name_ = other.name_;
      cmd_ = other.cmd_;
      cmdMatch_ = other.cmdMatch_;
      cmdRoom_ = other.cmdRoom_;
      selectData_ = other.selectData_ != null ? other.selectData_.Clone() : null;
      loadPercent_ = other.loadPercent_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PbMessage Clone() {
      return new PbMessage(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cmd" field.</summary>
    public const int CmdFieldNumber = 2;
    private global::Pb.PbMessage.Types.CMD cmd_ = global::Pb.PbMessage.Types.CMD.Login;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Pb.PbMessage.Types.CMD Cmd {
      get { return cmd_; }
      set {
        cmd_ = value;
      }
    }

    /// <summary>Field number for the "cmdMatch" field.</summary>
    public const int CmdMatchFieldNumber = 3;
    private global::Pb.PbMessage.Types.CmdMatch cmdMatch_ = global::Pb.PbMessage.Types.CmdMatch.JoinMatch;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Pb.PbMessage.Types.CmdMatch CmdMatch {
      get { return cmdMatch_; }
      set {
        cmdMatch_ = value;
      }
    }

    /// <summary>Field number for the "cmdRoom" field.</summary>
    public const int CmdRoomFieldNumber = 4;
    private global::Pb.PbMessage.Types.CmdRoom cmdRoom_ = global::Pb.PbMessage.Types.CmdRoom.Confirm;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Pb.PbMessage.Types.CmdRoom CmdRoom {
      get { return cmdRoom_; }
      set {
        cmdRoom_ = value;
      }
    }

    /// <summary>Field number for the "selectData" field.</summary>
    public const int SelectDataFieldNumber = 5;
    private global::Pb.SelectData selectData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Pb.SelectData SelectData {
      get { return selectData_; }
      set {
        selectData_ = value;
      }
    }

    /// <summary>Field number for the "loadPercent" field.</summary>
    public const int LoadPercentFieldNumber = 6;
    private int loadPercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int LoadPercent {
      get { return loadPercent_; }
      set {
        loadPercent_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PbMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PbMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Cmd != other.Cmd) return false;
      if (CmdMatch != other.CmdMatch) return false;
      if (CmdRoom != other.CmdRoom) return false;
      if (!object.Equals(SelectData, other.SelectData)) return false;
      if (LoadPercent != other.LoadPercent) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Cmd != global::Pb.PbMessage.Types.CMD.Login) hash ^= Cmd.GetHashCode();
      if (CmdMatch != global::Pb.PbMessage.Types.CmdMatch.JoinMatch) hash ^= CmdMatch.GetHashCode();
      if (CmdRoom != global::Pb.PbMessage.Types.CmdRoom.Confirm) hash ^= CmdRoom.GetHashCode();
      if (selectData_ != null) hash ^= SelectData.GetHashCode();
      if (LoadPercent != 0) hash ^= LoadPercent.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Cmd != global::Pb.PbMessage.Types.CMD.Login) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Cmd);
      }
      if (CmdMatch != global::Pb.PbMessage.Types.CmdMatch.JoinMatch) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CmdMatch);
      }
      if (CmdRoom != global::Pb.PbMessage.Types.CmdRoom.Confirm) {
        output.WriteRawTag(32);
        output.WriteEnum((int) CmdRoom);
      }
      if (selectData_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(SelectData);
      }
      if (LoadPercent != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(LoadPercent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Cmd != global::Pb.PbMessage.Types.CMD.Login) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Cmd);
      }
      if (CmdMatch != global::Pb.PbMessage.Types.CmdMatch.JoinMatch) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CmdMatch);
      }
      if (CmdRoom != global::Pb.PbMessage.Types.CmdRoom.Confirm) {
        output.WriteRawTag(32);
        output.WriteEnum((int) CmdRoom);
      }
      if (selectData_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(SelectData);
      }
      if (LoadPercent != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(LoadPercent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Cmd != global::Pb.PbMessage.Types.CMD.Login) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Cmd);
      }
      if (CmdMatch != global::Pb.PbMessage.Types.CmdMatch.JoinMatch) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CmdMatch);
      }
      if (CmdRoom != global::Pb.PbMessage.Types.CmdRoom.Confirm) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CmdRoom);
      }
      if (selectData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SelectData);
      }
      if (LoadPercent != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LoadPercent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PbMessage other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Cmd != global::Pb.PbMessage.Types.CMD.Login) {
        Cmd = other.Cmd;
      }
      if (other.CmdMatch != global::Pb.PbMessage.Types.CmdMatch.JoinMatch) {
        CmdMatch = other.CmdMatch;
      }
      if (other.CmdRoom != global::Pb.PbMessage.Types.CmdRoom.Confirm) {
        CmdRoom = other.CmdRoom;
      }
      if (other.selectData_ != null) {
        if (selectData_ == null) {
          SelectData = new global::Pb.SelectData();
        }
        SelectData.MergeFrom(other.SelectData);
      }
      if (other.LoadPercent != 0) {
        LoadPercent = other.LoadPercent;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Cmd = (global::Pb.PbMessage.Types.CMD) input.ReadEnum();
            break;
          }
          case 24: {
            CmdMatch = (global::Pb.PbMessage.Types.CmdMatch) input.ReadEnum();
            break;
          }
          case 32: {
            CmdRoom = (global::Pb.PbMessage.Types.CmdRoom) input.ReadEnum();
            break;
          }
          case 42: {
            if (selectData_ == null) {
              SelectData = new global::Pb.SelectData();
            }
            input.ReadMessage(SelectData);
            break;
          }
          case 48: {
            LoadPercent = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Cmd = (global::Pb.PbMessage.Types.CMD) input.ReadEnum();
            break;
          }
          case 24: {
            CmdMatch = (global::Pb.PbMessage.Types.CmdMatch) input.ReadEnum();
            break;
          }
          case 32: {
            CmdRoom = (global::Pb.PbMessage.Types.CmdRoom) input.ReadEnum();
            break;
          }
          case 42: {
            if (selectData_ == null) {
              SelectData = new global::Pb.SelectData();
            }
            input.ReadMessage(SelectData);
            break;
          }
          case 48: {
            LoadPercent = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PbMessage message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CMD {
        [pbr::OriginalName("login")] Login = 0,
        [pbr::OriginalName("match")] Match = 1,
        [pbr::OriginalName("room")] Room = 2,
      }

      public enum CmdMatch {
        [pbr::OriginalName("joinMatch")] JoinMatch = 0,
        [pbr::OriginalName("quitMatch")] QuitMatch = 1,
      }

      public enum CmdRoom {
        [pbr::OriginalName("confirm")] Confirm = 0,
        [pbr::OriginalName("select")] Select = 1,
        [pbr::OriginalName("selectDate")] SelectDate = 2,
        [pbr::OriginalName("load")] Load = 3,
        [pbr::OriginalName("loadData")] LoadData = 4,
        [pbr::OriginalName("fightStart")] FightStart = 5,
        [pbr::OriginalName("fightData")] FightData = 6,
        [pbr::OriginalName("dismissed")] Dismissed = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
