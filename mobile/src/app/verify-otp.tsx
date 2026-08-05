import { useState } from 'react';
import { Link, useRouter } from 'expo-router';
import { KeyboardAvoidingView, Platform, ScrollView, StyleSheet } from 'react-native';

import { AuthButton } from '@/components/auth-button';
import { AuthHeader } from '@/components/auth-header';
import { AuthInput } from '@/components/auth-input';
import { ThemedText } from '@/components/themed-text';
import { ThemedView } from '@/components/themed-view';
import { MaxContentWidth, Spacing } from '@/constants/theme';

export default function VerifyOtpScreen() {
  const router = useRouter();
  const [otp, setOtp] = useState('');

  return (
    <KeyboardAvoidingView
      style={styles.flex}
      behavior={Platform.OS === 'ios' ? 'padding' : undefined}>
      <ScrollView contentContainerStyle={styles.scrollContent}>
        <ThemedView style={styles.container}>
          <AuthHeader />

          <ThemedText type="title" style={styles.title}>
            Verifique seu código
          </ThemedText>
          <ThemedText themeColor="textSecondary" style={styles.subtitle}>
            Digite o código de 6 dígitos que enviamos para seu email.
          </ThemedText>

          <ThemedView style={styles.form}>
            <AuthInput
              label="Código OTP"
              placeholder="000000"
              keyboardType="number-pad"
              maxLength={6}
              value={otp}
              onChangeText={setOtp}
              style={styles.otpInput}
            />

            <AuthButton
              title="Verificar OTP"
              onPress={() => otp.trim() && router.push('/reset-password')}
            />
          </ThemedView>

          <ThemedView style={styles.footer}>
            <Link href="/forgot-password">
              <ThemedText type="link" themeColor="brandPrimary">Não recebeu o código?</ThemedText>
            </Link>
          </ThemedView>
        </ThemedView>
      </ScrollView>
    </KeyboardAvoidingView>
  );
}

const styles = StyleSheet.create({
  flex: {
    flex: 1,
  },
  scrollContent: {
    flexGrow: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
  container: {
    width: '100%',
    maxWidth: MaxContentWidth / 2,
    paddingHorizontal: Spacing.four,
    paddingVertical: Spacing.six,
    gap: Spacing.two,
  },
  title: {
    fontSize: 28,
    lineHeight: 34,
  },
  subtitle: {
    marginBottom: Spacing.three,
  },
  form: {
    gap: Spacing.three,
  },
  otpInput: {
    textAlign: 'center',
    letterSpacing: 8,
  },
  footer: {
    flexDirection: 'row',
    justifyContent: 'center',
    marginTop: Spacing.four,
  },
});
