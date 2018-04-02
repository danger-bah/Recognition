using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    public class IS
    {
        public static bool FullPath(string expression, params string[] allowedExtension)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return false;

            expression = expression.Trim();
            if (expression.Length > 255)
                return false;

            if (!Verify.NotChars(expression, Patterns.NotPathChars))
                return false;

            string ext = System.IO.Path.GetExtension(expression);
            if (string.IsNullOrWhiteSpace(ext) || ext.Length > 16)
                return false;
            
            if (allowedExtension.Length > 0 && !allowedExtension.Contains(ext))
                return false;

            return true;
        }

        public static bool DirectoryPath(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return false;

            expression = expression.Trim();
            if (expression.Length > 255)
                return false;

            if (!Verify.NotChars(expression, Patterns.NotPathChars))
                return false;

            string ext = System.IO.Path.GetExtension(expression);
            if (!string.IsNullOrWhiteSpace(ext))
                return false;
            return true;
        }

        public static bool FileName(string expression, params string[] allowedExtension)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return false;

            expression = expression.Trim();
            if (expression.Length > 128)
                return false;
            if (!Verify.NotChars(expression, Patterns.NotFileNameChars))
                return false;

            string ext = System.IO.Path.GetExtension(expression);
            if (string.IsNullOrWhiteSpace(ext) || ext.Length > 16)
                return false;

            if (allowedExtension.Length > 0 && !allowedExtension.Contains(ext))
                return false;

            return true;
        }

        public static bool Email(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return false;

            expression = expression.Trim();
            if (expression.Length > 128 || expression.Length < 6)
                return false;
            if (!Verify.RegexMatch(expression, Patterns.EmailRgx))
                return false;
            return true;
        }

        public static bool Password(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return false;

            if (expression.Length > 32 || expression.Length < 6)
                return false;

            if (!Verify.Chars(expression, Patterns.Password))
                return false;
            return true;
        }

        public static bool Url(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return false;

            expression = expression.Trim();
            if (expression.Length > 255)
                return false;
            Uri uri;
            return Uri.TryCreate(expression, UriKind.Absolute, out uri)
                && (uri.Scheme == Uri.UriSchemeHttp
                 || uri.Scheme == Uri.UriSchemeHttps
                 || uri.Scheme == Uri.UriSchemeFtp);
            //|| uri.Scheme == Uri.UriSchemeMailto);
        }

        public static bool Login(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return false;

            expression = expression.Trim();
            if (expression.Length > 32 || expression.Length < 4)
                return false;
            if (!Verify.Chars(expression, Patterns.EnLetters))
                return false;
            return true;
        }

        public static bool Name(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return false;

            expression = expression.Trim();
            if (expression.Length > 128 || expression.Length < 3)
                return false;
            if (!Verify.Chars(expression, Patterns.CyrilicLetters))
                return false;

            return true;
        }
    }
}
