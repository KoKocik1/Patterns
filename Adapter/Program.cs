﻿using Adapter.Interface;
using Adapter.Model;
using Adapter.Utils;
using Autofac;
using Autofac.Features.Metadata;

internal class Program
{
    private static readonly List<VectorObject> vectorObjects = new()
    {
        new VectorRectangle(1, 1, 10, 10),
        new VectorRectangle(3, 3, 6, 6)
    };

    private static void Main(string[] args)
    {
        //example adapter
        DrawUtils.Draw(vectorObjects);
        DrawUtils.Draw(vectorObjects);

        // generic adapter
        var v = new Vector2i(1, 2);
        v[0] = 0;

        var vv = new Vector2i(3, 1);

        var result = v + vv;

        var vector3f = Vector3f.Create(2.2f, 3.3f, 4.4f);

        var b = new ContainerBuilder();
        b.RegisterType<SaveCommand>().As<ICommand>()
            .WithMetadata("Name", "Save");
        b.RegisterType<OpenCommand>().As<ICommand>()
            .WithMetadata("Name", "Open");
        //b.RegisterType<Button>();
        //b.RegisterAdapter<ICommand, Button>(cmd => new Button(cmd));
        b.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
            new Button(cmd.Value, (string)cmd.Metadata["Name"]));
        b.RegisterType<Editor>();

        using (var c = b.Build())
        {
            var editor = c.Resolve<Editor>();
            editor.ClickAll();

            foreach (var button in editor.Buttons) button.Print();
        }
    }
}