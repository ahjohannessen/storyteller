using System;

namespace StoryTeller.Samples.Grammars
{
    public class CompositeFixture : MathFixture
    {
        public CompositeFixture()
        {
            this["AddAndMultiply"] = Script("Add and Multiply", x =>
            {
                x += this["StartWith"];
                x += this["Add"];
                x += this["MultiplyBy"];
                x += this["TheValueShouldBe"];
            });

            this["AddAndMultiplyTable"] = this["AddAndMultiply"].AsTable("Add and Multiply in a Table");

            this["AddAndMultiplyThrow"] = Script("Add and Multiply", x =>
            {
                x += this["StartWith"];
                x += this["Add"];
                x += this["MultiplyBy"];
                x += Do(() => { throw new NotImplementedException(); });
                x += this["TheValueShouldBe"];
            });
        }
    }
}