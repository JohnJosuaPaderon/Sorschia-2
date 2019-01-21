using System.Text;

namespace Sorschia.Convention
{
    internal sealed class FullNameBuilder : NameBuilderBase, IFullNameBuilder
    {
        public string Build(NameBase name)
        {
            var builder = new StringBuilder();

            var hasFirstName = HasValue(name.FirstName);
            var hasMiddleName = HasValue(name.MiddleName);
            var hasLastName = HasValue(name.LastName);
            var hasNameExtension = HasValue(name.NameExtension);

            if (hasLastName)
            {
                builder.Append(name.LastName.Trim());

                if (hasNameExtension)
                {
                    builder.Append(SPACE);
                }
                else if (hasFirstName || hasMiddleName)
                {
                    builder.Append(COMMA_SPACE);
                }
            }

            if (hasNameExtension)
            {
                builder.Append(name.NameExtension.Trim());

                if (hasFirstName || hasMiddleName)
                {
                    builder.Append(COMMA_SPACE);
                }
            }

            if (hasFirstName)
            {
                builder.Append(name.FirstName.Trim());

                if (hasMiddleName)
                {
                    builder.Append(SPACE);
                }
            }

            if (hasMiddleName)
            {
                builder.Append(name.MiddleName.Trim());
            }

            return builder.ToString();
        }
    }
}
