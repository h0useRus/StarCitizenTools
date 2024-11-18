using System.ComponentModel.DataAnnotations;

namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The game client mode
/// </summary>
public enum ClientMode
{
    /// <summary>
    /// Live Universe.
    /// </summary>
    [Display(Name = "LIVE")]
    Live,
    /// <summary>
    /// Public Test Universe.
    /// </summary>
    [Display(Name = "PTU")]
    PTU,
    /// <summary>
    /// Experimental Public Test Universe.
    /// </summary>
    [Display(Name = "EPTU")]
    EPTU,
    /// <summary>
    /// Tech Preview
    /// </summary>
    [Display(Name = "TECH-PREVIEW")]
    TechPreview
}

