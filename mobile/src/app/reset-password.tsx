import { useState } from 'react';
import { useRouter } from 'expo-router';
import { KeyboardAvoidingView, Platform, ScrollView, StyleSheet } from 'react-native';

import { AuthButton } from '@/components/auth-button';
import { AuthHeader } from '@/components/auth-header';
import { AuthInput } from '@/components/auth-input';
import { ThemedText } from '@/components/themed-text';
import { ThemedView } from '@/components/themed-view';
import { MaxContentWidth, Spacing } from '@/constants/theme';

export default function ResetPasswordScreen() {
  const router = useRouter();
  const [password, setPassword] = useState('');
  const [passwordConfirmation, setPasswordConfirmation] = useState('');

  return (
    <KeyboardAvoidingView
      style={styles.flex}
      behavior={Platform.OS === 'ios' ? 'padding' : undefined}>
      <ScrollView contentContainerStyle={styles.scrollContent}>
        <ThemedView style={styles.container}>
          <AuthHeader />

          <ThemedText type="title" style={styles.title}>
            Crie uma nova senha
          </ThemedText>
          <ThemedText themeColor="textSecondary" style={styles.subtitle}>
            Sua nova senha deve ser diferente da anterior.
          </ThemedText>

          <ThemedView style={styles.form}>
            <AuthInput
              label="Nova senha"
              placeholder="********"
              secureTextEntry
              value={password}
              onChangeText={setPassword}
            />
            <AuthInput
              label="Confirme a nova senha"
              placeholder="********"
              secureTextEntry
              value={passwordConfirmation}
              onChangeText={setPasswordConfirmation}
            />

            <AuthButton
              title="Resetar senha"
              onPress={() => password.trim() && passwordConfirmation.trim() && router.replace('/login')}
            />
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
});
