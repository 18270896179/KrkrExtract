# CS_ARCH_ARM, CS_MODE_THUMB, None
0xf1,0xff,0xa0,0x08 = vtbl.8 d16, {d17}, d16
0xf0,0xff,0xa2,0x09 = vtbl.8 d16, {d16, d17}, d18
0xf0,0xff,0xa4,0x0a = vtbl.8 d16, {d16, d17, d18}, d20
0xf0,0xff,0xa4,0x0b = vtbl.8 d16, {d16, d17, d18, d19}, d20
0xf0,0xff,0xe1,0x28 = vtbx.8 d18, {d16}, d17
0xf0,0xff,0xe2,0x39 = vtbx.8 d19, {d16, d17}, d18
0xf0,0xff,0xe5,0x4a = vtbx.8 d20, {d16, d17, d18}, d21
0xf0,0xff,0xe5,0x4b = vtbx.8 d20, {d16, d17, d18, d19}, d21
