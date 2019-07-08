# firmware-wintools

OpenWrtのfirmware-utilsのWindows移植（という名の適当再現）

## ヘルプ

```firmware-wintools -h```

## 機能
現在 nec-enc のみ

---

### nec-enc

OpenWrtにおけるnec-encの機能を提供します。

使用方法:

```firmware-wintools nec-enc -i <input file> -o <output file> -k <key>```

```firmware-wintools nec-enc -h```

確認済み機種:

- Aterm WG1200CR

恐らく対応する機種:

- Aterm WR8165N
- Aterm WR8166N
- Aterm WF300HP2
- Aterm WF800HP
- Aterm WF1200CR
- Aterm WG2600HS
- その他Realtek SoCを搭載する11acモデル全般

注意:

WG2600HPxシリーズやMRxxLNシリーズ、WR4100N及びその類似機種はファームウェアの暗号化方法が異なるため、使用できません。

---

## 動作確認済環境

- Windows 10 1903
- .NET Framework 4.7.2

## バージョン履歴

- 0.1.0 - 初版（nec-enc）

## ライセンス

MIT

## Thanks

- OpenWrt project team
- all contributors in OpenWrt project