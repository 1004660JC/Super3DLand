using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTextureGen : MonoBehaviour
{
	public Material mat;

	public Color Color1;
	public Color Color2;
	// Use this for initialization
	void Start()
	{
		mat.mainTexture = CreateTexture();
	}

	private Texture2D CreateTexture()
	{
		var tex = new Texture2D(2, 2);
		tex.filterMode = FilterMode.Point;
		tex.SetPixels(new Color[] { Color1, Color2, Color2, Color1 });
		tex.Apply();
		return tex;
	}
}
