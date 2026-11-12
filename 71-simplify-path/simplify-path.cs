public class Solution {
  public string SimplifyPath(string path) {
    var directories = new Stack<string>();

    var parts = path.Split("/");

    foreach (var part in parts) {
      if (part == string.Empty || part == ".") {
        continue;
      }

      if (part == "..") {
        if (directories.Count > 0) {
          directories.Pop();
        }
      } else {
        directories.Push(part);
      }
    }

    var realPath = new Stack<string>();

    while (directories.Count > 0) {
      realPath.Push(directories.Pop());
    }

    return "/" + string.Join("/", realPath);
  }
}