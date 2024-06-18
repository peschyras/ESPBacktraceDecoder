# ESPBacktraceDecoder
A small GUI for the Espressif tool addr2Line to decode backtraces.

This tool uses the programm "xtensa-esp32-elf-addr2line" frome the ESP-IDF toolbox to decode a back trace into human readable stack trace.

![image](https://github.com/peschyras/ESPBacktraceDecoder/assets/124285103/8c790048-431c-4102-ad67-6e8626b16fae)

How to Use:
1. Open a firmware.elf file by clicking on the button "Select Firmware"
2. Paste a backtrace into the textbox.
3. Click "Decode"

The command behind this GUI is: 
```
xtensa-esp32-elf-addr2line -pfiaC -e build/PROJECT.elf ADDRESS
```

More information here: [Automatic Address Decoding](https://docs.espressif.com/projects/esp-idf/en/latest/esp32/api-guides/tools/idf-monitor.html#automatic-address-decoding)

Example Backtrace
```
Backtrace: 0x400f360d:0x3ffb7e00 0x400dbf56:0x3ffb7e20 0x400dbf5e:0x3ffb7e40 0x400dbf82:0x3ffb7e60 0x400d071d:0x3ffb7e90
```

Example Output:
```
0x400f360d: do_something_to_crash at /home/gus/esp/32/idf/examples/get-started/hello_world/main/./hello_world_main.c:57
(inlined by) inner_dont_crash at /home/gus/esp/32/idf/examples/get-started/hello_world/main/./hello_world_main.c:52
0x400dbf56: still_dont_crash at /home/gus/esp/32/idf/examples/get-started/hello_world/main/./hello_world_main.c:47
0x400dbf5e: dont_crash at /home/gus/esp/32/idf/examples/get-started/hello_world/main/./hello_world_main.c:42
0x400dbf82: app_main at /home/gus/esp/32/idf/examples/get-started/hello_world/main/./hello_world_main.c:33
0x400d071d: main_task at /home/gus/esp/32/idf/components/esp32/./cpu_start.c:254
```
