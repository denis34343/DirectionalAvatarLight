
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class DirectionalAvatarLight : UdonSharpBehaviour
{
    public Texture2D tex;
    public Shader shader;
    public Light DirectionalLight;

    void Start()
    {
        var cam = this.GetComponent<Camera>();
        cam.SetReplacementShader(shader, "");
    }

    void OnPostRender()
    {
        tex.ReadPixels(new Rect(0, 0, 1, 3), 0, 0, false);
        tex.Apply();
        Color pixels = tex.GetPixel(0, 0);

        // RenderSettings.ambientSkyColor = pixels[0] + Ambience;
        // RenderSettings.ambientEquatorColor = pixels[1] + Ambience;
        // RenderSettings.ambientGroundColor = pixels[2] + Ambience;
        DirectionalLight.color = pixels;

    }
}
