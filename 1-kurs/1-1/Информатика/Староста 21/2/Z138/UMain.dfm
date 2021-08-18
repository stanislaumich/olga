object Form1: TForm1
  Left = 0
  Top = 0
  Caption = #1056#1072#1073#1086#1090#1072' '#1089#1086' '#1089#1087#1080#1089#1082#1086#1084
  ClientHeight = 207
  ClientWidth = 447
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 8
    Top = 158
    Width = 41
    Height = 13
    Caption = #1057#1090#1088#1086#1082#1072':'
  end
  object Label2: TLabel
    Left = 8
    Top = 184
    Width = 73
    Height = 13
    Caption = #1053#1086#1084#1077#1088' '#1089#1090#1088#1086#1082#1080':'
  end
  object ListBox1: TListBox
    Left = 4
    Top = 4
    Width = 441
    Height = 145
    ItemHeight = 13
    Items.Strings = (
      #1047#1085#1072#1095#1077#1085#1080#1077' 1'
      #1047#1085#1072#1095#1077#1085#1080#1077' 2'
      #1047#1085#1072#1095#1077#1085#1080#1077'3')
    TabOrder = 0
  end
  object Edit1: TEdit
    Left = 52
    Top = 155
    Width = 282
    Height = 21
    TabOrder = 1
  end
  object Button1: TButton
    Left = 340
    Top = 153
    Width = 105
    Height = 25
    Caption = #1044#1086#1073#1072#1074#1080#1090#1100
    TabOrder = 2
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 340
    Top = 180
    Width = 105
    Height = 25
    Caption = #1059#1076#1072#1083#1080#1090#1100
    TabOrder = 3
    OnClick = Button2Click
  end
  object UpDown1: TUpDown
    Left = 149
    Top = 180
    Width = 16
    Height = 21
    Associate = Edit2
    TabOrder = 4
  end
  object Edit2: TEdit
    Left = 88
    Top = 180
    Width = 61
    Height = 21
    TabOrder = 5
    Text = '0'
  end
end
