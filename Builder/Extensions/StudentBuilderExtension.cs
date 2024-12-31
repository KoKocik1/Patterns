using Builder.Builders;

namespace Builder.Extensions;

public static class StudentBuilderExtension
{
    public static StudentBuilder StudyAt(this StudentBuilder builder, string university)
    {
        return builder.Do(s => s.University = university);
    }
}