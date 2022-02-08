# Documentation

<p align = "center">
  <a>
    <img src="https://raw.githubusercontent.com/Neotoxic-off/Miia/main/assets/logo.png" height="25%" width="25%"/>
    <div align = "center">
        <i>Miia is an illegal movie manager</i>
    </div>
    <div align = "center">
        <i>Watch with easiness your downloaded series & anime</i>
    </div>
  </a>
</p>

## Library Prepartion

If the serie / anime has only 1 season you can create a subfolder or not
If you don't create one, by default Miia will create one by using the default
name specifies on the configuration file and all the files will be moved inside
the folder created except the `splash.jpg`

#### Using subfolder for seasons

```
📁 Library
└ 📁 Evangelion
  ├ 📄 splash.png
  └ 📁 Season 1
    ├ 📄 episode_1.mp4
    ├ 📄 episode_2.mp4
    ├ 📄 episode_3.mp4
    ├ 📄 episode_4.mp4
    ├ 📄 episode_5.mp4
    ├ 📄 episode_6.mp4
    ├ 📄 episode_7.mp4
    ├ 📄 episode_8.mp4
    ├ 📄 episode_9.mp4
    ├ 📄 episode_10.mp4
    ├ 📄 episode_11.mp4
    └ 📄 episode_12.mp4
```

#### Without using subfolder for seasons

Before
```
📁 Library
└ 📁 No Game no Life
  ├ 📄 splash.png
  ├ 📄 episode_1.mp4
  ├ 📄 episode_2.mp4
  ├ 📄 episode_3.mp4
  ├ 📄 episode_4.mp4
  ├ 📄 episode_5.mp4
  ├ 📄 episode_6.mp4
  ├ 📄 episode_7.mp4
  ├ 📄 episode_8.mp4
  ├ 📄 episode_9.mp4
  ├ 📄 episode_10.mp4
  ├ 📄 episode_11.mp4
  └ 📄 episode_12.mp4
```

After
```
📁 Library
└ 📁 No Game no Life
  ├ 📄 splash.png
  └ 📁 Season 1
    ├ 📄 episode_1.mp4
    ├ 📄 episode_2.mp4
    ├ 📄 episode_3.mp4
    ├ 📄 episode_4.mp4
    ├ 📄 episode_5.mp4
    ├ 📄 episode_6.mp4
    ├ 📄 episode_7.mp4
    ├ 📄 episode_8.mp4
    ├ 📄 episode_9.mp4
    ├ 📄 episode_10.mp4
    ├ 📄 episode_11.mp4
    └ 📄 episode_12.mp4
```

## Default splash screen

If the serie / anime folder doesn't contains `splash.jpg`
The following splash will be displayed instead

<img src="https://raw.githubusercontent.com/Neotoxic-off/Miia/main/assets/no_splash.png" height="25%" width="25%"/>

## Release Hierarchy

```
📁 Miia
├ 📁 assets
│ └ 📄 no_splash.png
├ 📁 configuration
│ └ 📄 configuration.json
├ 📄 Miia.exe
└ 📄 Miia.conf
```

## Data Format

```JSON
{
    "version": null,
    "root": null,
    "default_name" : "Season 1",
    "splash_size": {
        "width": 128,
        "height": 192
    },
    "favorite": [
        {
            "name": null,
            "path": null,
            "splash": null,
            "read": null
        }
    ],
    "queue": [
        {
            "name": null,
            "path": null,
            "splash": null,
            "read": null
        }
    ],
    "library": [
        {
            "name": null,
            "path": null,
            "splash": null,
            "read": null
        }
    ]
}
```
