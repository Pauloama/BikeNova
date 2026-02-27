import { LinearGradient } from "expo-linear-gradient"
import {
    StyleSheet,
    Text,
    TouchableOpacity,
    TouchableOpacityProps,
} from "react-native"
import { useAppFonts } from "@/hooks/useAppFonts"

type ButtonProps = TouchableOpacityProps & {
    label: string
    cores?: string[]
    coresTexto?: string
}

export function Button({ label, cores,coresTexto, style , ...rest}: ButtonProps) {
    const isLoaded = useAppFonts()
    const coresPadrao = ["#FFBDAC", "#CA3C17", "#FFBDAC"]
    const corTextoPadrao = "#FFFFFF"
    return (
        <TouchableOpacity activeOpacity={0.8} style ={style} {...rest}>
            <LinearGradient
                colors={(cores || coresPadrao) as [string, string, ...string[]]}
                style={styles.container}
                start={{ x: 0, y: 0 }}
                end={{ x: 1, y: 0 }}>
                <Text style={[styles.label, {color: coresTexto|| corTextoPadrao}]}>{label}</Text>
            </LinearGradient>
        </TouchableOpacity>
    )
}

const styles = StyleSheet.create({
    container: {
        width: 318,
        height: 44,
        alignItems: "center",
        justifyContent: "center",
        borderRadius: 8
    },
    label: {
        color: "#FFFFFF",
        fontSize: 20,
        fontFamily: "Roboto_700Bold",
        justifyContent: "center"
    },
})