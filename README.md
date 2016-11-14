# AngleSharp.Demos.Indotnet

Simple and sweet demonstration playground for AngleSharp as shown in the Indotnet usergroup on November 2016.

If you have anything to add to the demo, then feel free to do so. Push requests are always highly appreciated.

## Running the Sample

The demo is a Visual Studio 2015 solution that uses C# 6 together with the AngleSharp library. For demonstration purposes also the AngleSharp.Scripting.JavaScript library has been loaded.

The application is a WPF UI that uses the MVVM pattern. The main viewmodel is the `MainViewModel`. Here the connection to the transformation is designed. The `ParseAsync` method is called when the source code (via the `Source` property) changes.

Generally, the code is quite similar to the demo for the Munich.NET usergroup, however, this one does not include any CSS parts and focuses on a live preview.

## Playing around with the Sample

The thing that can be done is typing in elemental parts of any HTML document such as `<!doctype html>`. Seeing it being interpreted in real time (e.g., first as a text, then a comment, finally the doctype) is wonderful - educational and working-wise. Also complex examples can be shown in no time; how HTML5 treats nested tables or complicated formatting.

The scoping rules (applied to paragraphs `<p>` or list items `<li>` for example) can also be demonstrated easily. Plus we get some immediate grasp on topics such as raw text (`title` element) or the `<plaintext>` tag (there is no way out!).

Another thing is that a JavaScript engine has been integrated. Thus parsing the following chunk of HTML code actually does something:

```html
<script>console.log('Hi Mum!')</script>
```

The debug output view of Visual Studio should display "Hi Mum!". This can be abused as such:

```html
<script>document.write('<span>again</span>')</script>
```

Inserting this and pressing "Transform!" multiple types will repeat the *again* in the `span` element. This is a nice way to "grow" a document. Granted, a rather boring document.

## License

The MIT License (MIT)

Copyright (c) 2016 AngleSharp

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
