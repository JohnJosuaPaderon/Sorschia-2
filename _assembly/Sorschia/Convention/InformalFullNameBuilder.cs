using System.Text;

namespace Sorschia.Convention
{
    internal sealed class InformalFullNameBuilder : NameBuilderBase, IInformalFullNameBuilder
    {
        public string Build(NameBase name)
        {
            var builder = new StringBuilder();

            var hasFirstName = HasValue(name.FirstName);
            var hasMiddleInitials = HasValue(name.MiddleInitials);
            var hasLastName = HasValue(name.LastName);
            var hasNameExtension = HasValue(name.NameExtension);

            if (hasFirstName)
            {
                builder.Append(name.FirstName.Trim());

                if (hasMiddleInitials || hasLastName || hasNameExtension)
                {
                    builder.Append(SPACE);
                }
            }

            if (hasMiddleInitials)
            {
                builder.Append($"{name.MiddleInitials}.");

                if (hasLastName || hasNameExtension)
                {
                    builder.Append(SPACE);
                }
            }

            if (hasLastName)
            {
                builder.Append(name.LastName.Trim());

                if (hasNameExtension)
                {
                    builder.Append(SPACE);
                }
            }

            if (hasNameExtension)
            {
                builder.Append(name.NameExtension);
            }

            return builder.ToString();
        }
    }
}
