// *************************************************************
// Type: GameFoundation.StringBuilderExtensions
// Assembly: GameFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92FD7834-EF64-4872-85C6-A525AB8BDDBE
// *************************************************************

using System;
using System.Text;

#nullable disable
namespace GameFoundation
{
  public static class StringBuilderExtensions
  {
    private static readonly char[] parentKeywords;
    private static readonly uint parentKeywords;
    private static readonly char parentKeywords;

    static StringBuilderExtensions()
    {
      char[] chArray = ActivatorSettings.DisconnectProject(ReferenceInvoker.DisconnectProject(696));
      ReferenceInvoker.DisconnectProject((Array) chArray, 700);
      StringBuilderExtensions.parentKeywords = chArray;
      StringBuilderExtensions.parentKeywords = (uint) ReferenceInvoker.DisconnectProject(733);
      StringBuilderExtensions.parentKeywords = (char) ReferenceInvoker.DisconnectProject(737);
    }

    public static StringBuilder Concat(
      this StringBuilder string_builder,
      uint uint_val,
      uint pad_amount,
      char pad_char,
      uint base_val)
    {
      uint val2 = (uint) ReferenceInvoker.DisconnectProject(572);
      uint num = uint_val;
      do
      {
        num /= base_val;
        val2 += (uint) ReferenceInvoker.DisconnectProject(576);
      }
      while (num > (uint) ReferenceInvoker.DisconnectProject(580));
      string_builder.Append(pad_char, (int) Math.Max(pad_amount, val2));
      int length = string_builder.Length;
      for (; val2 > (uint) ReferenceInvoker.DisconnectProject(592); val2 -= (uint) ReferenceInvoker.DisconnectProject(588))
      {
        length -= ReferenceInvoker.DisconnectProject(584);
        string_builder[length] = StringBuilderExtensions.parentKeywords[(IntPtr) (uint_val % base_val)];
        uint_val /= base_val;
      }
label_5:
      switch (5)
      {
        case 0:
          goto label_5;
        default:
          if (false)
          {
            // ISSUE: method reference
            RuntimeMethodHandle runtimeMethodHandle = __methodref (StringBuilderExtensions.Concat);
          }
          return string_builder;
      }
    }

    public static StringBuilder Concat(this StringBuilder string_builder, uint uint_val)
    {
      string_builder.Concat(uint_val, (uint) ReferenceInvoker.DisconnectProject(596), StringBuilderExtensions.parentKeywords, (uint) ReferenceInvoker.DisconnectProject(600));
      return string_builder;
    }

    public static StringBuilder Concat(
      this StringBuilder string_builder,
      uint uint_val,
      uint pad_amount)
    {
      string_builder.Concat(uint_val, pad_amount, StringBuilderExtensions.parentKeywords, (uint) ReferenceInvoker.DisconnectProject(604));
      return string_builder;
    }

    public static StringBuilder Concat(
      this StringBuilder string_builder,
      uint uint_val,
      uint pad_amount,
      char pad_char)
    {
      string_builder.Concat(uint_val, pad_amount, pad_char, (uint) ReferenceInvoker.DisconnectProject(608));
      return string_builder;
    }

    public static StringBuilder Concat(
      this StringBuilder string_builder,
      int int_val,
      uint pad_amount,
      char pad_char,
      uint base_val)
    {
      if (int_val < ReferenceInvoker.DisconnectProject(612))
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (StringBuilderExtensions.Concat);
            }
            string_builder.Append(EditorService.DisconnectProject(525));
            uint uint_val = (uint) (ReferenceInvoker.DisconnectProject(616) - int_val + ReferenceInvoker.DisconnectProject(620));
            string_builder.Concat(uint_val, pad_amount, pad_char, base_val);
            break;
        }
      }
      else
        string_builder.Concat((uint) int_val, pad_amount, pad_char, base_val);
      return string_builder;
    }

    public static StringBuilder Concat(this StringBuilder string_builder, int int_val)
    {
      string_builder.Concat(int_val, (uint) ReferenceInvoker.DisconnectProject(624), StringBuilderExtensions.parentKeywords, (uint) ReferenceInvoker.DisconnectProject(628));
      return string_builder;
    }

    public static StringBuilder Concat(
      this StringBuilder string_builder,
      int int_val,
      uint pad_amount)
    {
      string_builder.Concat(int_val, pad_amount, StringBuilderExtensions.parentKeywords, (uint) ReferenceInvoker.DisconnectProject(632));
      return string_builder;
    }

    public static StringBuilder Concat(
      this StringBuilder string_builder,
      int int_val,
      uint pad_amount,
      char pad_char)
    {
      string_builder.Concat(int_val, pad_amount, pad_char, (uint) ReferenceInvoker.DisconnectProject(636));
      return string_builder;
    }

    public static StringBuilder Concat(
      this StringBuilder string_builder,
      float float_val,
      uint decimal_places,
      uint pad_amount,
      char pad_char)
    {
      if (decimal_places == 0U)
      {
label_1:
        switch (7)
        {
          case 0:
            goto label_1;
          default:
            if (false)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (StringBuilderExtensions.Concat);
            }
            int int_val = (double) float_val < (double) ReferenceInvoker.DisconnectProject(640) ? (int) ((double) float_val - (double) ReferenceInvoker.DisconnectProject(648)) : (int) ((double) float_val + (double) ReferenceInvoker.DisconnectProject(644));
            string_builder.Concat(int_val, pad_amount, pad_char, (uint) ReferenceInvoker.DisconnectProject(652));
            break;
        }
      }
      else
      {
        int int_val = (int) float_val;
        string_builder.Concat(int_val, pad_amount, pad_char, (uint) ReferenceInvoker.DisconnectProject(656));
        string_builder.Append(EditorService.DisconnectProject(528));
        float num = Math.Abs(float_val - (float) int_val);
        do
        {
          num *= ReferenceInvoker.DisconnectProject(660);
          decimal_places -= (uint) ReferenceInvoker.DisconnectProject(664);
        }
        while (decimal_places > (uint) ReferenceInvoker.DisconnectProject(668));
        float uint_val = num + ReferenceInvoker.DisconnectProject(672);
        string_builder.Concat((uint) uint_val, (uint) ReferenceInvoker.DisconnectProject(676), (char) ReferenceInvoker.DisconnectProject(680), (uint) ReferenceInvoker.DisconnectProject(684));
      }
      return string_builder;
    }

    public static StringBuilder Concat(this StringBuilder string_builder, float float_val)
    {
      string_builder.Concat(float_val, StringBuilderExtensions.parentKeywords, (uint) ReferenceInvoker.DisconnectProject(688), StringBuilderExtensions.parentKeywords);
      return string_builder;
    }

    public static StringBuilder Concat(
      this StringBuilder string_builder,
      float float_val,
      uint decimal_places)
    {
      string_builder.Concat(float_val, decimal_places, (uint) ReferenceInvoker.DisconnectProject(692), StringBuilderExtensions.parentKeywords);
      return string_builder;
    }

    public static StringBuilder Concat(
      this StringBuilder string_builder,
      float float_val,
      uint decimal_places,
      uint pad_amount)
    {
      string_builder.Concat(float_val, decimal_places, pad_amount, StringBuilderExtensions.parentKeywords);
      return string_builder;
    }
  }
}
