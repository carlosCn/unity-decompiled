﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.ParticleRendererEditor
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 01B28312-B6F5-4E06-90F6-BE297B711E41
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEditor.dll

using UnityEngine;

namespace UnityEditor
{
  [CustomEditor(typeof (ParticleRenderer))]
  [CanEditMultipleObjects]
  internal class ParticleRendererEditor : RendererEditorBase
  {
    public override void OnEnable()
    {
      base.OnEnable();
    }

    public override void OnInspectorGUI()
    {
      this.serializedObject.Update();
      Editor.DrawPropertiesExcluding(this.serializedObject);
      this.serializedObject.ApplyModifiedProperties();
    }
  }
}
