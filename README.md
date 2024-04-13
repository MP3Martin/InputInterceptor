### Fork for personal use.

Credit goes to [0x2E757](https://github.com/0x2E757) @ https://github.com/0x2E757/InputInterceptor/

#### What was added:
- You can now return `true` or `false` in `KeyboardHook`'s and `MouseHook`'s `CallbackAction` if you want to forward the key stroke.
  - `true`: the original key that triggered the `CallbackAction` [gets pressed in the end](https://github.com/MP3Martin/InputInterceptor-PersonalFork/blob/4c30421d482c8c16195a59649b94951789956b06/InputInterceptor%2FClasses%2FHook.cs#L75-L77)
  - `false`: -||- doesn't get pressed

Available as a [NuGet package](https://www.nuget.org/packages/MP3Martin.InputInterceptor.PersonalFork/).
