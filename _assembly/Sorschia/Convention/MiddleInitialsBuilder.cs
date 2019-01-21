using System;
using System.Text;

namespace Sorschia.Convention
{
    internal sealed class MiddleInitialsBuilder : NameBuilderBase, IMiddleInitialsBuilder
    {
        public string Build(NameBase name)
        {
            var builder = new StringBuilder();

            var cleansed = RemoveDoubleSeparators(name.MiddleName);
            var chunks = cleansed.Split(new string[] { SPACE }, StringSplitOptions.RemoveEmptyEntries);

            if (chunks.Length > 0)
            {
                foreach (var chunk in chunks)
                {
                    var firstCharacter = chunk[0];

                    if (char.IsLetter(firstCharacter))
                    {
                        builder.Append(firstCharacter);
                    }
                }
            }

            return builder.ToString();
        }
    }
}
