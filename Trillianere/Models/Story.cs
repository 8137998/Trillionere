using System;
using System.Collections.Generic;

namespace Trillianere.Models;

public partial class Story
{
    public int StoryId { get; set; }

    public string ImageId { get; set; } = null!;

    public string? ImageAltText { get; set; }

    public string? ImageRedirectUrl { get; set; }

    public string? Title { get; set; }

    public DateTime? PostDate { get; set; }

    public string? Description { get; set; }
}
