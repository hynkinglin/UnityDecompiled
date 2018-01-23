﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.GridPaintTargetsDropdown
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using System;

namespace UnityEditor
{
  internal class GridPaintTargetsDropdown : FlexibleMenu
  {
    public GridPaintTargetsDropdown(IFlexibleMenuItemProvider itemProvider, int selectionIndex, FlexibleMenuModifyItemUI modifyItemUi, Action<int, object> itemClickedCallback, float minWidth)
      : base(itemProvider, selectionIndex, modifyItemUi, itemClickedCallback)
    {
      this.minTextWidth = minWidth;
    }

    internal class MenuItemProvider : IFlexibleMenuItemProvider
    {
      public int Count()
      {
        return GridPaintingState.validTargets == null ? 0 : GridPaintingState.validTargets.Length;
      }

      public object GetItem(int index)
      {
        return GridPaintingState.validTargets == null ? (object) GridPaintingState.scenePaintTarget : (object) GridPaintingState.validTargets[index];
      }

      public int Add(object obj)
      {
        throw new NotImplementedException();
      }

      public void Replace(int index, object newPresetObject)
      {
        throw new NotImplementedException();
      }

      public void Remove(int index)
      {
        throw new NotImplementedException();
      }

      public object Create()
      {
        throw new NotImplementedException();
      }

      public void Move(int index, int destIndex, bool insertAfterDestIndex)
      {
        throw new NotImplementedException();
      }

      public string GetName(int index)
      {
        return GridPaintingState.validTargets == null ? GridPaintingState.scenePaintTarget.name : GridPaintingState.validTargets[index].name;
      }

      public bool IsModificationAllowed(int index)
      {
        return false;
      }

      public int[] GetSeperatorIndices()
      {
        return new int[0];
      }
    }
  }
}