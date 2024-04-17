using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Entities.ValueObject;
public sealed record Review
{
    public Review(int rating, string? comment)
    {
        if (rating < 0 || rating > 5)
        {
            throw new ArgumentOutOfRangeException(nameof(rating));
        }

        Rating = rating;
        Comment = comment ?? string.Empty;
    }

    public int Rating { get; private set; }
    public string? Comment { get; private set; }
}
